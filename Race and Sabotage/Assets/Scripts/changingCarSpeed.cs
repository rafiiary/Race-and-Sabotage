using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using TMPro;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class changingCarSpeed : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        public GameObject input_destination;
        private TMP_Text text;

        private void Awake()
        {
            // get the car controller
            ////debug.log("CHANGEINGCARSPEEDS");
            Time.timeScale = 1;
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            ////print("H" + (h * 10000).ToString());
            float v = CrossPlatformInputManager.GetAxis("Vertical");
            ////print("V" + v.ToString());
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(0, 0, 0, 0f);
            if (input_destination.transform.childCount > 0)
            {
                //m_Car.Move(h, v, v, handbrake);
                ////print(input_destination.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text);
                text = input_destination.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>();
                m_Car.m_Topspeed = float.Parse(text.text);
                ////debug.log("THE CAR MAX SPEED CHOSEN IS " + m_Car.m_Topspeed.ToString());
                m_Car.Move(0, 1000000000000, 0, 0);
                if (m_Car.m_Topspeed > 100)
                {
                    GetComponent<Rigidbody>().AddForce(800f, 0f, 0f);
                }
            }
            else
            {
                //m_Car.m_Topspeed = 0;
                //m_Car.Move(0, 0, 0, 0f);
            }
#else
            //m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}
