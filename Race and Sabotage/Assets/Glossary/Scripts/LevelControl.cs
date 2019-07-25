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
            level3.onClick.AddListener(delegate { loadScene("InfiniteTerrain 8"); });
            level4.onClick.AddListener(delegate { loadScene("InfiniteTerrain 12"); });
            level1.onClick.AddListener(delegate { loadScene("InfiniteTerrain"); });
            level2.onClick.AddListener(delegate { loadScene("InfiniteTerrain 4"); });
            level5.enabled = false;
        }
        else if (dropDownOption == 1) // conditions
        {
            level3.enabled = true;
            level4.enabled = true;
            level1.enabled = true;
            level2.enabled = true;
            level5.enabled = false;
            level4.onClick.AddListener(delegate { loadScene("InfiniteTerrain 13"); });
            //level5.onClick.AddListener(delegate { loadScene("Loading6"); });
            level1.onClick.AddListener(delegate { loadScene("InfiniteTerrain 1"); });
            level2.onClick.AddListener(delegate { loadScene("InfiniteTerrain 5"); });
            level3.onClick.AddListener(delegate { loadScene("InfiniteTerrain 10"); });
        }
        else if (dropDownOption == 2) // for loops
        {
            level3.enabled = true;
            level4.enabled = true;
            level5.enabled = false;
            level1.enabled = true;
            level2.enabled = true;
            //level5.onClick.AddListener(delegate { loadScene("Level3Scene2"); });
            level4.onClick.AddListener(delegate { loadScene("InfiniteTerrain 14"); });
            level3.onClick.AddListener(delegate { loadScene("InfiniteTerrain 11"); });
            level1.onClick.AddListener(delegate { loadScene("InfiniteTerrain 3"); });
            level2.onClick.AddListener(delegate { loadScene("InfiniteTerrain 7"); });
        }

        else if (dropDownOption == 3) // while loops
        {
            level1.enabled = true;
            level2.enabled = true;
            level3.enabled = true;
            level4.enabled = true;
            level5.enabled = false;
            level1.onClick.AddListener(delegate { loadScene("InfiniteTerrain 2"); });
            level2.onClick.AddListener(delegate { loadScene("InfiniteTerrain 6"); });
            level3.onClick.AddListener(delegate { loadScene("InfiniteTerrain 9"); });
            level4.onClick.AddListener(delegate { loadScene("InfiniteTerrain 15"); });
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
