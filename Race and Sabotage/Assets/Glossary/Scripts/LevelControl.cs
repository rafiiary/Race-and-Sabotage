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
        if (dropDownOption == 0)
        {
            level3.enabled = true;
            level4.enabled = true;
            level1.enabled = true;
            level2.enabled = true;
            level3.onClick.AddListener(delegate { loadScene("NewScene"); });
            level4.onClick.AddListener(delegate { loadScene("Level1Scene2"); });
            level1.onClick.AddListener(delegate { loadScene("Level1Scene"); });
            level2.onClick.AddListener(delegate { loadScene("Change_terrain_chapter1"); });
            level5.enabled = false;
        }
        else if (dropDownOption == 1)
        {
            level3.enabled = true;
            level4.enabled = true;
            level1.enabled = true;
            level2.enabled = true;
            level5.enabled = true;
            level4.onClick.AddListener(delegate { loadScene("NewScene2"); });
            level5.onClick.AddListener(delegate { loadScene("Level2Scene2"); });
            level1.onClick.AddListener(delegate { loadScene("Level2Scene"); });
            level2.onClick.AddListener(delegate { loadScene("Change_terrain_chapter2"); });
            level3.onClick.AddListener(delegate { loadScene("DragAndDrop"); });
        }
        else if (dropDownOption == 2)
        {
            level3.enabled = true;
            level4.enabled = true;
            level5.enabled = false;
            level1.enabled = true;
            level2.enabled = true;
            level4.onClick.AddListener(delegate { loadScene("Level3Scene2"); });
            level3.onClick.AddListener(delegate { loadScene("WhileLoops"); });
            level1.onClick.AddListener(delegate { loadScene("Change_terrain_chapter3"); });
            level2.onClick.AddListener(delegate { loadScene("DragAndDrop2"); });
        }
    }
    public void updateButtons()
    {
        dropDownOption = dropdown.GetComponent<TMP_Dropdown>().value;
    }
    void loadScene(string sceneName)
    {
        loadingText.GetComponent<TextMeshProUGUI>().text = "Loading...";
        SceneManager.LoadScene(sceneName);
    }
}
