using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerPause2 : MonoBehaviour
{
    private Canvas TriggeredCanvas;
    public Canvas PauseCanvas;
    public Canvas GlossaryCanvas;
    public GameObject car;
    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        TriggeredCanvas = GetComponent<Canvas>();
        PauseCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    /* SHOWING THE MAIN MENU */

    public void ShowPause()
    {
        //debug.log("SHOW the parent of camera was " + camera.transform.parent.ToString());
        camera.transform.SetParent(PauseCanvas.transform);
        //debug.log("SHOW the parent of camera was then " + camera.transform.parent.ToString());
        TriggeredCanvas.gameObject.SetActive(false);
        PauseCanvas.gameObject.SetActive(true);
    }

    public void UnshowPause()
    {
        //debug.log("UNSHOW the parent of camera was " + camera.transform.parent.ToString());
        camera.transform.SetParent(TriggeredCanvas.transform);
        //debug.log("UNSHOW the parent of camera was then " + camera.transform.parent.ToString());
        Vector3 posvec = car.transform.position;
        posvec.y += (float)3;
        posvec.x += (float)8;
        camera.transform.position = posvec;
        //debug.log("THE POSITION OF THE CAMERA IS NOW " + posvec);
        TriggeredCanvas.gameObject.SetActive(true);
        PauseCanvas.gameObject.SetActive(false);
    }

    /* SHOWING THE GLOSSARY */

    public void ShowGlossary()
    {
        SceneManager.LoadScene("Glossary");
        //GlossaryCanvas.gameObject.SetActive(true);
        //PauseCanvas.gameObject.SetActive(false);

    }

    public void ShowSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void ExitApplication()
    {
        Application.Quit();
    }

    public void ExitToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }



}

