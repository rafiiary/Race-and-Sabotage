using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using TMPro;
using System.Collections;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class ClickRight : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        public static float turn =0 ;
        private bool timeDone;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }

        private void FixedUpdate()
        {
            IEnumerator Example()
            {
                timeDone = false;
                yield return new WaitForSeconds((float)0.2);
                timeDone = true;
            }
        }
        private void OnMouseDown()
        {
            m_Car.Move(turn, 2, 0, 0);
        }
    }
}
