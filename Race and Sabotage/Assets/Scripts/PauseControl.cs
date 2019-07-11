using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseControl : MonoBehaviour
{
    public Button pauseButton;
    public Canvas PauseMenu;
    bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        pauseButton.onClick.AddListener(PauseGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGame()
    {
        if (isPaused)
        {
            Debug.Log("PAUSECONTROL");
            Time.timeScale = 1;
            PauseMenu.gameObject.SetActive(false);
            isPaused = false;
        } 
        else
        {
            Time.timeScale = 0;
            PauseMenu.gameObject.SetActive(true);
            isPaused = true;
        }
    }
}
