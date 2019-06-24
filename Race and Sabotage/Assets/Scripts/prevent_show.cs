using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prevent_show : MonoBehaviour
{
    public GameObject speedometer;
    public GameObject pause;
    public GameObject self;
    public GameObject fixingbug;
    public GameObject waypointcar;
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
        if (waypointcar.active == true) 
        {
            Debug.Log("did it enterrrrrr????????????");
            pause.SetActive(true);
        }
    }
}
