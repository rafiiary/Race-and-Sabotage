using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class betting_canvas_script : MonoBehaviour
{
    public Camera camera;
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    public GameObject input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void continue_on()
    {
        gameObject.active = false;
        car1.active = true;
        car2.active = true;
        car3.active = true;
    }
}
