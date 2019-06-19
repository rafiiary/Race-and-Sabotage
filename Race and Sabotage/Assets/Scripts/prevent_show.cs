using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prevent_show : MonoBehaviour
{
    public GameObject speedometer;
    public GameObject pause;
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
        speedometer.SetActive(false);
        pause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        print(self.active);
        if (self.active == false)
        {
            //speedometer.SetActive(true);
            pause.SetActive(true);
        }
    }
}
