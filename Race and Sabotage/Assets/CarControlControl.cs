using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlControl : MonoBehaviour
{
    public GameObject Car;
    private CarUserControl carUserControl;

    private void Start()
    {
        carUserControl = Car.GetComponent<CarUserControl>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Car.AddComponent<CarStraightControl> ();
        //carUserControl.gameObject.SetActive(false);
    }
}
