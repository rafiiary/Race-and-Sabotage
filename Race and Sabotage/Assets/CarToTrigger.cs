using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarToTrigger : MonoBehaviour
{
    //ShowPanel showPanel = new ShowPanel();
    public Canvas TriggeredCanvas;
    private bool paused = false;
    public Image wrongimage;
    private int counter = 0;

    void Start()
    {
        TriggeredCanvas.gameObject.SetActive(false);
        wrongimage.gameObject.SetActive(false);
    }

    void Update()
    {
        if (counter > 0)
        {
            wrongimage.gameObject.SetActive(true);
            counter--;
        }
        else
        {
            wrongimage.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        paused = true;
        AudioListener.pause = true;
        Time.timeScale = 0;
        //showPanel.pauseGame();
        TriggeredCanvas.gameObject.SetActive(true);
        Debug.Log("THE CAR COLLIDED WITH " + gameObject.name);


        Debug.Log("Paused became true!");
    }

    private void OnTriggerExit(Collider other)
    {
        UnpauseGame();
    }

    public void UnpauseGame()
    {
        if (DropZone2.firstbox && DropZone2.secondbox && DropZone2.thirdbox)
        {
            AudioListener.pause = false;
            Time.timeScale = 1;
            paused = false;
            TriggeredCanvas.gameObject.SetActive(false);
            Debug.Log("WE UNPAUSED BOYS");
            Destroy(gameObject);
        }
        else
        {
            //wrongimage.gameObject.SetActive(true);
            counter = 60;
        }

    }
}
