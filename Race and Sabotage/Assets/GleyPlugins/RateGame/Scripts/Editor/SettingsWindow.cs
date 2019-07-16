namespace GleyRateGame
{
    using UnityEditor;
    using UnityEditor.SceneManagement;
    using UnityEngine;

    public class SettingsWindow : EditorWindow
    {
        private RateGameSettings adSettings;
        private DisplayConditions firstShowSettings;
        private DisplayConditions postponeSettings;
        private Vector2 scrollPosition = Vector2.zero;
        private RatePopupTypes ratePopupType;
        private string iosAppID;
        private string googlePlayBundleID;
        private string mainText;
        private string yesButtonText;
        private string noButton;
        private string laterButton;
        private string sendButton;
        private string notNowButton;
        private string neverButton;       
        private int minStarsToSend;
        private bool clearSave;
        

        [MenuItem("Window/Gley/Rate Game")]
        private static void Init()
        {
            SettingsWindow window = (SettingsWindow)GetWindow(typeof(SettingsWindow), true, "Rate Game Settings Window - v.1.0.1");
            window.minSize = new Vector2(520, 520);
            window.Show();
        }


        private void OnEnable()
        {
            adSettings = Resources.Load<RateGameSettings>("RateGameSettingsData");
            if (adSettings == null)
            {
                CreateAdSettings();
                adSettings = Resources.Load<RateGameSettings>("RateGameSettingsData");
            }

            //load asset values
            iosAppID = adSettings.iosAppID;
            ratePopupType = adSettings.ratePopupType;
            googlePlayBundleID = adSettings.googlePlayBundleID;
            mainText = adSettings.mainText;
            yesButtonText = adSettings.yesButton;
            noButton = adSettings.noButton;
            laterButton = adSettings.laterButton;
            sendButton = adSettings.sendButton;
            notNowButton = adSettings.notNowButton;
            neverButton = adSettings.neverButton;
            firstShowSettings = adSettings.firstShowSettings;
            postponeSettings = adSettings.postponeSettings;
            minStarsToSend = adSettings.minStarsToSend;
#if UNITY_EDITOR
            clearSave = adSettings.clearSave;
#endif
        }


        private void OnGUI()
        {
            EditorStyles.label.wordWrap = true;
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, false, false, GUILayout.Width(position.width), GUILayout.Height(position.height));

            EditorGUILayout.LabelField("Your App IDs:", EditorStyles.boldLabel);
            iosAppID = EditorGUILayout.TextField("iOS App ID", iosAppID);
            googlePlayBundleID = EditorGUILayout.TextField("Google Play bundle ID", googlePlayBundleID);
            EditorGUILayout.Space();

            GUILayout.Label("Customize popup text:", EditorStyles.boldLabel);
            ratePopupType = (RatePopupTypes)EditorGUILayout.EnumPopup("Select Rate Popup type: ", ratePopupType);
            EditorGUILayout.LabelField("Start Popup: - a popup with 5 stars selectable by user");
            EditorGUILayout.LabelField("Yes/No Popup: - a popup that asks the user if he/she wants to rate the app");
            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Main Popup Text:", GUILayout.Width(146));
            var areaStyle = new GUIStyle(GUI.skin.textArea);
            areaStyle.wordWrap = true;
            var width = position.width - 35;
            areaStyle.fixedHeight = 0;
            areaStyle.fixedHeight = areaStyle.CalcHeight(new GUIContent(mainText), width);
            mainText = EditorGUILayout.TextArea(mainText, areaStyle, GUILayout.Height(areaStyle.fixedHeight));
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.Space();

            if (ratePopupType == RatePopupTypes.StarsPopup)
            {
                sendButton = EditorGUILayout.TextField("Send Button", sendButton);
                minStarsToSend = EditorGUILayout.IntField("Min Stars to Open Store:", minStarsToSend);
                EditorGUILayout.LabelField("Opens the store page to rate on if user gives more that " + minStarsToSend + " stars");
                EditorGUILayout.Space();

                notNowButton = EditorGUILayout.TextField("Not now button", notNowButton);
                EditorGUILayout.LabelField("Closes the popup, but it will open again based on your conditions");
                EditorGUILayout.Space();

                neverButton = EditorGUILayout.TextField("Never button", neverButton);
                EditorGUILayout.LabelField("Closes the popup, popup never opens again");
                EditorGUILayout.Space();
            }

            if (ratePopupType == RatePopupTypes.YesNoPopup)
            {
                yesButtonText = EditorGUILayout.TextField("Yes button ", yesButtonText);
                EditorGUILayout.LabelField("Opens the store page to rate");
                EditorGUILayout.Space();

                noButton = EditorGUILayout.TextField("No button", noButton);
                EditorGUILayout.LabelField("Closes the popup, popup never opens again(this user does not like your game)");
                EditorGUILayout.Space();

                laterButton = EditorGUILayout.TextField("Later button (opens again later)", laterButton);
                EditorGUILayout.LabelField("Closes the popup, but it will open again based on your conditions");
                EditorGUILayout.Space();
            }

            EditorGUILayout.LabelField("If a button text is empty, that button will not show. At least one button should be active");
            EditorGUILayout.Space();
            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Show Options:", EditorStyles.boldLabel);
            EditorGUILayout.LabelField("First Show:", EditorStyles.boldLabel);
            ShowDisplaySettings(firstShowSettings);

            EditorGUILayout.LabelField("Postponed:", EditorStyles.boldLabel);
            ShowDisplaySettings(postponeSettings);

#if UNITY_EDITOR
            clearSave = EditorGUILayout.Toggle("Clear Save", clearSave);
#endif

            //save settings
            EditorGUILayout.Space();
            if (GUILayout.Button("Save"))
            {
                SaveSettings();
            }
            EditorGUILayout.Space();

            if (GUILayout.Button("Open Test Scene"))
            {
                EditorSceneManager.OpenScene("Assets/GleyPlugins/RateGame/Example/TestScene.unity");
            }

            GUILayout.EndScrollView();
        }


        private void ShowDisplaySettings(DisplayConditions showSettings)
        {
            showSettings.useSessionsCount = EditorGUILayout.Toggle("Use Sessions Count:", showSettings.useSessionsCount);
            if (showSettings.useSessionsCount)
            {
                showSettings.minSessiosnCount = EditorGUILayout.IntField("Number of Sessions:", showSettings.minSessiosnCount);
            }

            showSettings.useCustomEvents = EditorGUILayout.Toggle("Use Custom Events:", showSettings.useCustomEvents);
            if (showSettings.useCustomEvents)
            {
                showSettings.minCustomEvents = EditorGUILayout.IntField("Number of Custom Events:", showSettings.minCustomEvents);
            }
            showSettings.useInGameTime = EditorGUILayout.Toggle("Use In Game Time:", showSettings.useInGameTime);
            if (showSettings.useInGameTime)
            {
                showSettings.gamePlayTime = EditorGUILayout.IntField("Number of minutes:", showSettings.gamePlayTime);
            }
            showSettings.useRealTime = EditorGUILayout.Toggle("Use Real Time: ", showSettings.useRealTime);
            if(showSettings.useRealTime)
            {
                showSettings.realTime = EditorGUILayout.FloatField("Number Of Hours:", showSettings.realTime);
            }
            if (showSettings.useSessionsCount == false && showSettings.useCustomEvents == false && showSettings.useInGameTime == false)
            {
                EditorGUILayout.LabelField("The rate popup will be shown when ShowRatePopup() method is called (no delay)");
            }
            else
            {
                string text = "The rate popup will be shown after";
                if (showSettings.useSessionsCount)
                {
                    text += " " + showSettings.minSessiosnCount + " sessions";
                }

                if (showSettings.useCustomEvents)
                {
                    if (showSettings.useSessionsCount)
                    {
                        text += " and";
                    }
                    text += " " + showSettings.minCustomEvents + " custom events";
                }

                if (showSettings.useInGameTime)
                {
                    if (showSettings.useCustomEvents || showSettings.useSessionsCount)
                    {
                        text += " and";
                    }
                    text += " " + showSettings.gamePlayTime + " game play minutes";
                }

                if(showSettings.useRealTime)
                {
                    if(showSettings.useInGameTime || showSettings.useCustomEvents || showSettings.useSessionsCount)
                    {
                        text += " and";
                    }
                    text += " " + showSettings.realTime + " real time hours after app was first open";
                }
                EditorGUILayout.LabelField(text);
            }
        }


        private void SaveSettings()
        {
            adSettings.iosAppID = iosAppID;
            adSettings.googlePlayBundleID = googlePlayBundleID;
            adSettings.ratePopupType = ratePopupType;
            adSettings.mainText = mainText;
            adSettings.yesButton = yesButtonText;
            adSettings.noButton = noButton;
            adSettings.laterButton = laterButton;
            adSettings.sendButton = sendButton;
            adSettings.notNowButton = notNowButton;
            adSettings.neverButton = neverButton;
            adSettings.firstShowSettings = firstShowSettings;
            adSettings.postponeSettings = postponeSettings;
            adSettings.minStarsToSend = minStarsToSend;
            adSettings.clearSave = clearSave;
            SetSelectedPopup();
            EditorUtility.SetDirty(adSettings);
        }


        private void CreateAdSettings()
        {
            RateGameSettings asset = ScriptableObject.CreateInstance<RateGameSettings>();
            if (!AssetDatabase.IsValidFolder("Assets/GleyPlugins/RateGame/Resources"))
            {
                AssetDatabase.CreateFolder("Assets/GleyPlugins/RateGame", "Resources");
                AssetDatabase.Refresh();
            }

            AssetDatabase.CreateAsset(asset, "Assets/GleyPlugins/RateGame/Resources/RateGameSettingsData.asset");
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }


        private void SetSelectedPopup()
        {
            GameObject popup = AssetDatabase.LoadAssetAtPath("Assets/GleyPlugins/RateGame/Prefabs/" + ratePopupType.ToString() + ".prefab", typeof(GameObject)) as GameObject;
            adSettings.popupGameObject = popup;
            GameObject canvas = AssetDatabase.LoadAssetAtPath("Assets/GleyPlugins/RateGame/Prefabs/RatePopupCanvas.prefab", typeof(GameObject)) as GameObject;
            adSettings.ratePopupCanvas = canvas;
        }
    }
}
