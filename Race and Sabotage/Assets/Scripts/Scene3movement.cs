using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using TMPro;
using System.Collections;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class Scene3movement : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
            //m_WheelColliders = GetComponent<WheelCollider[]>();
        }

        private void FixedUpdate()
        {
            m_Car.Move(0, 4, 0, 0);
        }

    }
}
