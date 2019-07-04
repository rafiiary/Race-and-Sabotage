using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCanvasMakePauseInactive : MonoBehaviour
{
    public GameObject pausepanel;
    public GameObject winCanvas;
    public GameObject speedometer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (winCanvas.active == true)
        {
            pausepanel.SetActive(false);
            speedometer.SetActive(false);
        }
    }
}
