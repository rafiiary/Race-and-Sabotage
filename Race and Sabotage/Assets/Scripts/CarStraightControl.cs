using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class CarStraightControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        private Rigidbody m_Rigidbody;


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
            m_Rigidbody = GetComponent<Rigidbody>();

        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            ////print("H: " + (h * 10000).ToString());
            float v = CrossPlatformInputManager.GetAxis("Vertical");
            ////print("V: " + v.ToString());
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            //m_Car.Move(h, v, v, handbrake);
            m_Car.Move(0, 999999, 0, 0);
            if (h > 0)
            {
                //debug.log("greater than 0!!!!");
            }
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}
