using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowPanel : MonoBehaviour
{
    bool paused;
    public GameObject pausePanel;
    public GameObject confirmExitPanel;
    public GameObject confirmMainMenuPanel;
    public Canvas miniSettingsCanvas;
    public Canvas miniGlossaryCanvas;
    public GameObject codeExecutionPanel;
    private Canvas canvas;
    private void Start()
    {
        transform.SetAsLastSibling();
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
        pausePanel.transform.SetAsLastSibling();
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
        pausePanel.gameObject.SetActive(false);
        confirmMainMenuPanel.SetActive(false);
        confirmExitPanel.SetActive(true);
        pausePanel.SetActive(true);
    }

    public void cancelExit()
    {
        confirmExitPanel.SetActive(false);
        pausePanel.SetActive(true);
    }

    /* MAIN MENU */
    public void confirmMainMenu()
    {
        pausePanel.SetActive(false);
        confirmExitPanel.SetActive(false);
        confirmMainMenuPanel.SetActive(true);
        pausePanel.SetActive(false);
    }

    public void cancelMainMenu()
    {
        confirmMainMenuPanel.SetActive(false);
        pausePanel.gameObject.SetActive(true);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    /* SETTINGS */
    public void enableSettings()
    {
        miniSettingsCanvas.enabled = true;
        pausePanel.SetActive(false);
    }
    public void disableSettingsCanvas()
    {
        miniSettingsCanvas.enabled = false;
        pausePanel.SetActive(true);
    }

    /* GLOSSARY */
    public void enableGlossary()
    {
        miniGlossaryCanvas.enabled = true;
        pausePanel.SetActive(false);
    }
    public void disableGlossary()
    {
        miniGlossaryCanvas.enabled = false;
        pausePanel.SetActive(false);
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
}
