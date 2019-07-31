using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuReappear : MonoBehaviour
{
    public Button CancelButton;
    public GameObject MenuPanel;
    public GameObject ConfirmMainMenu;
    // Start is called before the first frame update
    void Start()
    {
        CancelButton.onClick.AddListener(PauseReappear);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PauseReappear()
    {
        ////debug.log("PRESSED");
        MenuPanel.gameObject.SetActive(true);
        ConfirmMainMenu.gameObject.SetActive(false);
    }
}
