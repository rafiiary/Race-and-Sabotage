using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityStandardAssets.Utility;

public class AddStraightPath : MonoBehaviour
{
    public GameObject Car; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        ////debug.log("WE HIT IT BOYSSSSSSSSS");
        Car.AddComponent<CarStraightControl>();
    }
}
