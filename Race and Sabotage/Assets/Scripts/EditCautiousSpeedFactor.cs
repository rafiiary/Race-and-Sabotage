using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityStandardAssets.Utility;

public class EditCautiousSpeedFactor : MonoBehaviour
{
    public GameObject car;
    private CarAIControl carAI;
    public float number;
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
        carAI = car.GetComponent<CarAIControl>();
        carAI.m_CautiousSpeedFactor = number;
    }
}
