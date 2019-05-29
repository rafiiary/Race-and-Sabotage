using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate_the_car : MonoBehaviour
{
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    // Start is called before the first frame update
    void Start()
    {
        car1.active = false;
        car2.active = false;
        car3.active = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
