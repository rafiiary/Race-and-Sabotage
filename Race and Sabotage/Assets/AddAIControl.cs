using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;
using UnityStandardAssets.Vehicles.Car;

public class AddAIControl : MonoBehaviour
{
    public GameObject Car;
    public Transform WaypointTargetObject;


    private CarAIControl prevAI;
    private WaypointProgressTracker prevWaypointProg;


    public WaypointCircuit WPcircuit;









    public GameObject WaypointCar;
    private CarUserControl carUserControl;
    private WaypointProgressTracker waypointProgressTracker;
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
        //Destroy(Car.GetComponent<CarAIControl>());
        //Destroy(Car.GetComponent<WaypointProgressTracker>());
        //Car.AddComponent<CarAIControl>();
        //Car.AddComponent<WaypointProgressTracker>();
        //WaypointCircuit circuit = WaypointCar.GetComponent<WaypointProgressTracker>().circuit;
        Car.GetComponent<WaypointProgressTracker>().circuit = WPcircuit;
        //Car.GetComponent<WaypointProgressTracker>().target = WaypointTargetObject;
        //Car.GetComponent<CarAIControl>().m_Driving = true;
        Car.GetComponent<CarAIControl>().SetTarget(WaypointTargetObject);
    }
}
