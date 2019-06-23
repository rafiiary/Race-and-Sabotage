using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityStandardAssets.Utility;

public class CarControlControl : MonoBehaviour
{
    public GameObject Car;
    public Transform WaypointTargetObject;
    public WaypointCircuit WPcircuit;









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
        Destroy(this);
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
        //WaypointCircuit circuit = WaypointCar.GetComponent<WaypointProgressTracker>().circuit;
        Car.GetComponent<WaypointProgressTracker>().circuit = WPcircuit;
        Car.GetComponent<WaypointProgressTracker>().target = WaypointTargetObject;
        //Car.GetComponent<CarAIControl>().m_Driving = true;
        Car.GetComponent<CarAIControl>().SetTarget(WaypointTargetObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        ImplementAIControl();
        Destroy(this);
    }

    public void ImplementLoopAI()
    {
        Car.AddComponent<LoopControl>();
    }
}
