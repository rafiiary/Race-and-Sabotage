using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelSelector : MonoBehaviour
{
    public GameObject DropdownMenu;
    public Button LevelSelectorButton;
    private int currentOption;
    public static string[] levels = { "Level1Scene","Change_terrain_chapter1", "Level2Scene", "Change_terrain_chapter2", "DragAndDrop","Change_terrain", "DragAndDrop2", "Change_terrain_chapter3" , "SampleScene" };
    // Start is called before the first frame update
    void Start()
    {
        LevelSelectorButton.onClick.AddListener(GoToLevel);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void GoToLevel()
    {
        SceneManager.LoadScene(levels[TextController.currentChosenOption]);
    }
}
