using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityStandardAssets.Utility;

public class CarControlControl : MonoBehaviour
{
    public GameObject Car;
    public GameObject WaypointCar;
    private CarUserControl carUserControl;
    private WaypointProgressTracker waypointProgressTracker;
    

    private void Start()
    {
        carUserControl = Car.GetComponent<CarUserControl>();
        WaypointCar.GetComponent<WaypointProgressTracker>();
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    Car.AddComponent<CarStraightControl> ();
    //    //carUserControl.gameObject.SetActive(false);
    //}

    public void ImplementStraightScript()
    {
        Car.AddComponent<CarStraightControl>();
    }

    public void ImplementLeftTurn()
    {
        Car.AddComponent<TurnLeftScript>();
    }

    public void ImplementRightTurn()
    {
        Car.AddComponent<TurnRightScript>();
    }

    public void ImplementSharpRight()
    {
        Car.AddComponent<SharpRightTurn>();
    }

    public void ImplementSharpLeft()
    {
        Car.AddComponent<SharpLeftTurn>();
    }

    public void ImplementAIControl()
    {
        Car.AddComponent<CarAIControl>();
        Car.AddComponent<WaypointProgressTracker>();
        WaypointCircuit circuit = WaypointCar.GetComponent<WaypointCircuit>();
        Car.GetComponent<WaypointProgressTracker>().SetWaypointCircuit(circuit);
    }

    private void OnTriggerEnter(Collider other)
    {
        ImplementAIControl();
    }
}
