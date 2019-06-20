using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelControl : MonoBehaviour
{
    public GameObject dropdown;
    public Button level1;
    public Button level2;
    public Button level3;
    int dropDownOption;
    void start()
    {
        dropDownOption = dropdown.GetComponent<TMP_Dropdown>().value;
    }
    void Update()
    {
        if (dropDownOption == 0)
        {
            level3.enabled = false;
            level1.onClick.AddListener(delegate { loadScene("Level1Scene"); });
            level2.onClick.AddListener(delegate { loadScene("Change_terrain_chapter1"); });
        }
        else if (dropDownOption == 1)
        {
            level3.enabled = true;
            level1.onClick.AddListener(delegate { loadScene("Level2Scene"); });
            level2.onClick.AddListener(delegate { loadScene("Change_terrain_chapter2"); });
            level3.onClick.AddListener(delegate { loadScene("DragAndDrop"); });
        }
        else if (dropDownOption == 2)
        {
            level3.enabled = true;
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
        SceneManager.LoadScene(sceneName);
    }
}
