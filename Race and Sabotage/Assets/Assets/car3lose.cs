using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car3lose : MonoBehaviour
{
    public GameObject camera;
    public GameObject losing_canvas;
    public string car_tag;
    // Start is called before the first frame update
    void Start()
    {
        losing_canvas.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (camera.transform.parent.tag == car_tag)
        {
            print("does it trigger the trigger car3");
            losing_canvas.active = true;
        }
        if (camera.transform.parent.tag == car_tag)
        {
            print("does it trigger the trigger car1");
            losing_canvas.active = true;
        }
    }
}
