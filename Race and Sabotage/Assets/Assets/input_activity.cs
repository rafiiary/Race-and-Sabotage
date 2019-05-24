using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input_activity : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public Camera camera;
      
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
        button1.active = false;
        button2.active = false;
        button3.active = false;
    }
}
