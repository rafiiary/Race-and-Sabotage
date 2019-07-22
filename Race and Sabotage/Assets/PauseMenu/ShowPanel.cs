using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowPanel : MonoBehaviour
{
    public static bool paused;
    public GameObject pausePanel;
    public GameObject menuPanel;
    public GameObject confirmExitPanel;
    public GameObject confirmMainMenuPanel;
    public Canvas miniSettingsCanvas;
    public Canvas miniGlossaryCanvas;
    public GameObject codeExecutionPanel;
    private Canvas canvas;
    public GameObject settings;
    private void Start()
    {
        //transform.SetAsLastSibling();
        menuPanel.SetActive(false);
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
        menuPanel.SetActive(true);
        disablePause();
        menuPanel.transform.SetAsLastSibling();
    }
    public void unpauseGame()
    {
        paused = false;
        menuPanel.SetActive(false);
        enablePause();
    }
    public void quitGame()
    {
        Application.Quit();
    }

    public void confirmExit()
    {
        menuPanel.gameObject.SetActive(false);
        confirmMainMenuPanel.SetActive(false);
        confirmExitPanel.SetActive(true);
        menuPanel.SetActive(false);
    }

    public void cancelExit()
    {
        confirmExitPanel.SetActive(false);
        menuPanel.SetActive(true);
    }

    /* MAIN MENU */
    public void confirmMainMenu()
    {
        menuPanel.SetActive(false);
        confirmExitPanel.SetActive(false);
        confirmMainMenuPanel.SetActive(true);
        menuPanel.SetActive(false);
    }

    public void cancelMainMenu()
    {
        confirmMainMenuPanel.SetActive(false);
        menuPanel.gameObject.SetActive(true);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    /* SETTINGS */
    public void enableSettings()
    {
        miniSettingsCanvas.gameObject.SetActive(true);
        miniSettingsCanvas.enabled = true;
        menuPanel.SetActive(false);
    }
    public void disableSettingsCanvas()
    {
        miniSettingsCanvas.enabled = false;
        menuPanel.SetActive(true);
    }

    /* GLOSSARY */
    public void enableGlossary()
    {
        miniGlossaryCanvas.enabled = true;
        menuPanel.SetActive(false);
    }
    public void disableGlossary()
    {
        miniGlossaryCanvas.enabled = false;
        menuPanel.SetActive(true);
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
    public void pause()
    {
        canvas = GetComponent<Canvas>();
        canvas.sortingOrder = 100;
    }
    public void resume()
    {
        canvas = GetComponent<Canvas>();
        canvas.sortingOrder = 0;
    }
    public void deactivate_settings()
    {
        //debug.log("PRESSSSSSSSSSSED");
        settings.SetActive(false);
        menuPanel.SetActive(true);
    }
    public void disableMenu()
    {
        menuPanel.SetActive(false);
    }

    public void disablePause()
    {
        pausePanel.SetActive(false);
    }
    public void enablePause()
    {
        pausePanel.SetActive(true);
    }
}
