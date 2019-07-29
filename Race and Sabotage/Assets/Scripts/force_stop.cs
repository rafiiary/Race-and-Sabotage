using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using TMPro;
using System.Collections;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class force_stop : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        private CarAIControl ai;
        public GameObject input_destination;
        private TMP_Text text;
        public GameObject first;
        public float time_to_delay;

        void Start()
        {
            StartCoroutine(Example());
        }
        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
            ai = GetComponent<CarAIControl>();

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
#else
            //m_Car.Move(h, v, v, 0f);
#endif
        }
        public IEnumerator Example()
        {
            yield return new WaitForSeconds(time_to_delay);
            m_Car.Move(0, 0, 0, 0f);
            m_Car.m_Topspeed = 0;
            ////debug.log("did it even enter????");
        }
    }
}
