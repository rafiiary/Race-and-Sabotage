using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelControl : MonoBehaviour
{
    public GameObject loadingText;
    public GameObject dropdown;
    public Button level1;
    public Button level2;
    public Button level3;
    public Button level4;
    public Button level5;
    int dropDownOption;
    void start()
    {
        dropDownOption = dropdown.GetComponent<TMP_Dropdown>().value;
        loadingText.GetComponent<TextMeshProUGUI>().text = "";
    }
    void Update()
    {
        if (dropDownOption == 0) // variables
        {
            level3.enabled = true;
            level4.enabled = true;
            level1.enabled = true;
            level2.enabled = true;
            level3.onClick.AddListener(delegate { loadScene("Loading9"); });
            level4.onClick.AddListener(delegate { loadScene("Loading13"); });
            level1.onClick.AddListener(delegate { loadScene("Loading1"); });
            level2.onClick.AddListener(delegate { loadScene("Loading5"); });
            level5.enabled = false;
        }
        else if (dropDownOption == 1) // conditions
        {
            level3.enabled = true;
            level4.enabled = true;
            level1.enabled = true;
            level2.enabled = true;
            level5.enabled = false;
            level4.onClick.AddListener(delegate { loadScene("Loading14"); });
            //level5.onClick.AddListener(delegate { loadScene("Loading6"); });
            level1.onClick.AddListener(delegate { loadScene("Loading2"); });
            level2.onClick.AddListener(delegate { loadScene("Loading6"); });
            level3.onClick.AddListener(delegate { loadScene("Loading11"); });
        }
        else if (dropDownOption == 2) // for loops
        {
            level3.enabled = true;
            level4.enabled = true;
            level5.enabled = false;
            level1.enabled = true;
            level2.enabled = true;
            //level5.onClick.AddListener(delegate { loadScene("Level3Scene2"); });
            level4.onClick.AddListener(delegate { loadScene("Loading15"); });
            level3.onClick.AddListener(delegate { loadScene("Loading12"); });
            level1.onClick.AddListener(delegate { loadScene("Loading4"); });
            level2.onClick.AddListener(delegate { loadScene("Loading8"); });
        }

        else if (dropDownOption == 3) // while loops
        {
            level1.enabled = true;
            level2.enabled = true;
            level3.enabled = true;
            level4.enabled = true;
            level5.enabled = false;
            level1.onClick.AddListener(delegate { loadScene("Loading3"); });
            level2.onClick.AddListener(delegate { loadScene("Loading7"); });
            level3.onClick.AddListener(delegate { loadScene("Loading10"); });
            level4.onClick.AddListener(delegate { loadScene("Loading16"); });
        }
    }
    public void updateButtons()
    {
        dropDownOption = dropdown.GetComponent<TMP_Dropdown>().value;
    }
    void loadScene(string sceneName)
    {
        loadingText.GetComponent<TextMeshProUGUI>().text = "Loading...";
        for (int i = 0; i < SceneArray.ArrayOfScenes.Length; i++)
        {
            if (sceneName == SceneArray.ArrayOfScenes[i])
            {
                SceneArray.SceneNumber = i;
            }
        }
        SceneManager.LoadScene(sceneName);
    }
}
