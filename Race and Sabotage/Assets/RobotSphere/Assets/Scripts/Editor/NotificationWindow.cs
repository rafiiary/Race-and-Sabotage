using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class NotificationWindow : EditorWindow
{
	static int post = 0;
	static string notificationSeenPref = "Notification.Seen";
	static GUIStyle style = new GUIStyle();
	static int windowId;
	public static void Init()
	{
		style.border = new RectOffset(10, 10, 10, 10);
		NotificationWindow window = ScriptableObject.CreateInstance<NotificationWindow>();
		window.position = new Rect(Screen.width / 2, Screen.height / 2, 500, 250);
		window.ShowPopup();
		windowId = window.GetInstanceID();
	}

	void OnGUI()
	{
		GUI.BringWindowToFront(windowId);
		style.fontSize = 35;
		style.wordWrap = true;
		style.normal.textColor = new Color(1f, 0.2373f, 0f, 1f);
		EditorGUILayout.LabelField("NOTIFICATION:\n", style);
		style.fontSize = 20;
		style.normal.textColor = Color.white;
		EditorGUILayout.LabelField("Animation Expansion Basic Pack for Robot Sphere is Available :)", style);
		GUILayout.Space(90);
		GUILayout.BeginHorizontal();
		GUI.backgroundColor = Color.red;
		if (GUILayout.Button("Remind me later..."))
		{
			this.Close();
		}
		GUILayout.Space(10);
		GUI.backgroundColor = Color.green;
		if (GUILayout.Button("Got It! Take me there!"))
		{
			Seen();
			Application.OpenURL("https://assetstore.unity.com/packages/slug/147055");
			this.Close();
		}
		GUILayout.EndHorizontal();
	}

	public static void Seen()
	{
		EditorPrefs.SetInt(notificationSeenPref, post);
	}

	public static bool AlreadySeen()
	{
		if (EditorPrefs.HasKey(notificationSeenPref))
		{
			if (EditorPrefs.GetInt(notificationSeenPref) <= post)
				return true;
		}
		return false;
	}
}

[InitializeOnLoad]
public class Startup
{
	
	static Startup()
	{
		EditorApplication.update += Notification;
	}

	static void Notification()
	{
		EditorApplication.update -= Notification;
		if (NotificationWindow.AlreadySeen())
			return;
		NotificationWindow.Init();
	}
}
