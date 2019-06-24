using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;
using UnityStandardAssets.Vehicles.Car;

public class RemoveBrakingAssist : MonoBehaviour
{
    public GameObject car;
    private AddBrakingAssist brakingAssist;

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

        Destroy(car.GetComponent<AddBrakingAssist>());
    }
}
