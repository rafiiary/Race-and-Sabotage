using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input_activity : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    public GameObject camera;
    private string which_car;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void betting_time(GameObject car)
    {
        gameObject.active = true;
        transform.position = new Vector3(car.transform.position.x, car.transform.position.y, car.transform.position.z);
        print(transform.position);
        button1.active = false;
        button2.active = false;
        button3.active = false;
        if (transform.position.x == 701.0)
        {
            which_car = "car1";
        }
        if (transform.position.x == 963.0)
        {
            which_car = "car2";
        }
        if (transform.position.x == 1219.0)
        {
            which_car = "car3";
        }
        //camera.transform.parent = car.transform;
    }
    public void attach_camera_to_car()
    {
        if (which_car == "car1")
            {
            camera.transform.parent = car1.transform;
        }
        if (which_car == "car2")
        {
            camera.transform.parent = car2.transform;
        }
        if (which_car == "car3")
        {
            camera.transform.parent = car3.transform;
        }
    }
}
