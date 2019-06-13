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
    public Canvas miniGlossaryCanvas;
    public GameObject codeExecutionPanel;
    private void Start()
    {
        pausePanel.SetActive(false);
        confirmExitPanel.SetActive(false);
        confirmMainMenuPanel.SetActive(false);
        miniSettingsCanvas.enabled = false;
        miniGlossaryCanvas.enabled = false;
        codeExecutionPanel.SetActive(true);
        paused = false;
    }
    /* Pause and Quit */
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

    /* MAIN MENU */
    public void confirmMainMenu()
    {
        confirmMainMenuPanel.SetActive(true);
    }

    public void cancelMainMenu()
    {
        confirmMainMenuPanel.SetActive(false);
    }
    /* SETTINGS */
    public void enableSettings()
    {
        miniSettingsCanvas.enabled = true;
    }
    public void disableSettingsCanvas()
    {
        miniSettingsCanvas.enabled = false;
    }

    /* GLOSSARY */
    public void enableGlossary()
    {
        miniGlossaryCanvas.enabled = true;
    }
    public void disableGlossary()
    {
        miniGlossaryCanvas.enabled = false;
    }

    private void Update()
    {
        if (paused)
        {
            AudioListener.pause = true;
            Time.timeScale = 0;
            codeExecutionPanel.SetActive(false);
        }
        else
        {
            AudioListener.pause = false;
            Time.timeScale = 1;
            codeExecutionPanel.SetActive(true);
        }
    }
}
