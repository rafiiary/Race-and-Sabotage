using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuDisappear : MonoBehaviour
{
    public Button MainMenuButton;
    public GameObject menuPanel;
    public GameObject ConfirmExitPanel;
    public GameObject ConfirmMainMenu;
    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton.onClick.AddListener(CanvasDisappear);
        ConfirmMainMenu.gameObject.SetActive(false);
        ConfirmExitPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CanvasDisappear()
    {
        menuPanel.gameObject.SetActive(false);
        ConfirmMainMenu.gameObject.SetActive(true);
        ConfirmExitPanel.gameObject.SetActive(false);
    }
}
