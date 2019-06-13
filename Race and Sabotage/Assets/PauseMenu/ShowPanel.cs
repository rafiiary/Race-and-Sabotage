using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPanel : MonoBehaviour
{
    bool paused;
    public GameObject pausePanel;
    public GameObject confirmExitPanel;
    public GameObject confirmMainMenuPanel;
    public Canvas miniSettingsCanvas;
    private void Start()
    {
        pausePanel.SetActive(false);
        confirmExitPanel.SetActive(false);
        confirmMainMenuPanel.SetActive(false);
        miniSettingsCanvas.enabled = false;
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
    public void quitGame()
    {
        Application.Quit();
    }

    public void confirmExit()
    {
        confirmExitPanel.SetActive(true);
    }

    public void cancelExit()
    {
        confirmExitPanel.SetActive(false);
    }

    public void confirmMainMenu()
    {
        confirmMainMenuPanel.SetActive(true);
    }

    public void cancelMainMenu()
    {
        confirmMainMenuPanel.SetActive(false);
    }
    public void enableSettings()
    {
        miniSettingsCanvas.enabled = true;
    }
    public void disableSettingsCanvas()
    {
        miniSettingsCanvas.enabled = false;
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
