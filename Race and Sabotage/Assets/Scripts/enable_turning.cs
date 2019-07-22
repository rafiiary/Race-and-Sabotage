using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using TMPro;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class enable_turning : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        public GameObject input_destination;
        private Vector3 temp;
        public GameObject car;
        private bool check = false;

        private void Awake()
        {
            m_Car = car.GetComponent<CarController>();// get the car controller
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Dreamcar01")
            {
                input_destination.SetActive(true);
            }
            temp = other.transform.position;
            check = true;
        }
        public void FixedUpdate()
        {
            if (check)
            {
                //print("check");
                m_Car.m_Topspeed = 0;
            }
        }


    }
}
