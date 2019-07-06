using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityStandardAssets.Utility;

public class AddCirclingMotionToCar: MonoBehaviour
{
    public GameObject car;
    private WaypointProgressTracker progresstracker;
    private CarAIControl carControl;

    private void OnTriggerEnter(Collider other)
    {
        progresstracker = car.GetComponent<WaypointProgressTracker>();
        carControl = car.GetComponent<CarAIControl>();
        //progresstracker.gameObject.SetActive(false);
        //carControl.gameObject.SetActive(false);
        car.AddComponent<CirclingMotion>();
        EndCanvasTimer.TimerInt = 100;
    }
}