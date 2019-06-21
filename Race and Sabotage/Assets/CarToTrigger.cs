using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarToTrigger : MonoBehaviour
{
    //ShowPanel showPanel = new ShowPanel();
    public Canvas TriggeredCanvas;
    private bool paused = false;

    void Start()
    {
        TriggeredCanvas.gameObject.SetActive(false);
    }

    void Update()
    {
        if (paused)
        {
            Debug.Log("IM PAUSED NOW!" + paused.ToString());
            AudioListener.pause = true;
            Time.timeScale = 0;
            //codeExecutionPanel.SetActive(false);
        }
        else
        {
            AudioListener.pause = false;
            Time.timeScale = 1;
            //codeExecutionPanel.SetActive(true);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        paused = true;
        //showPanel.pauseGame();
        TriggeredCanvas.gameObject.SetActive(true);
        Debug.Log("THE CAR COLLIDED WITH " + gameObject.name);

        Debug.Log("Paused became true!");
    }

    private void OnTriggerExit(Collider other)
    {
        //UnpauseGame();
    }

    public void UnpauseGame()
    {
        paused = false;
        TriggeredCanvas.gameObject.SetActive(false);
        Debug.Log("WE UNPAUSED BOYS");  
    }
}
