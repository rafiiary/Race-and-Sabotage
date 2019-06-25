using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPauseScript : MonoBehaviour
{
    private Canvas TriggeredCanvas;
    public Canvas PauseCanvas;

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

    public void ShowPause()
    {
        TriggeredCanvas.gameObject.SetActive(false);
        PauseCanvas.gameObject.SetActive(true);
    }

    public void UnshowPause()
    {
        TriggeredCanvas.gameObject.SetActive(true);
        PauseCanvas.gameObject.SetActive(false);
    }
}
