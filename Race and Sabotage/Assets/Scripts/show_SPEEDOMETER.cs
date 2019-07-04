using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class show_SPEEDOMETER : MonoBehaviour
{
    public GameObject canvas;
    public GameObject speedometer;
    private bool check = true;
    // Start is called before the first frame update
    void Start()
    {
        speedometer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (canvas.active == true)
        {
            speedometer.SetActive(true);
            check = false;
        }
        else
        {
            if (check)
            {
                speedometer.SetActive(false);
            }
        }
            
    }
}
