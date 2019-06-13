using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPanel : MonoBehaviour
{
    bool paused;
    public GameObject pausePanel;
    private void Start()
    {
        pausePanel.SetActive(false);
        paused = false;
    }
    public void pauseGame()
    {
        paused = true;
        pausePanel.SetActive(true);
    }
    public void unpauseGame()
    {
        paused = false;
        pausePanel.SetActive(false);
    }
    private void Update()
    {
        if (paused)
        {
            AudioListener.pause = true;
            Time.timeScale = 0;
        }
        else
        {
            AudioListener.pause = false;
            Time.timeScale = 1;
        }
    }
}
