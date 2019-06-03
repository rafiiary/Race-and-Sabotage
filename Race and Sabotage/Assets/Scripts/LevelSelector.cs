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
    string[] levels = { "Level1Scene", "Change_terrain", "SampleScene" };
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
