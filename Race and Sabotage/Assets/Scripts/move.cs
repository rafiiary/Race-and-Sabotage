using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class move : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        public GameObject drop1;
        public GameObject drop2;
        public GameObject dragAndDropCanvas;
        public bool left = false;
        bool right = false;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            //print("H" + (h * 10000).ToString());
            float v = CrossPlatformInputManager.GetAxis("Vertical");
            //print("V" + v.ToString());
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            if (drop1.transform.childCount > 0 && drop2.transform.childCount > 0)
            {
                dragAndDropCanvas.SetActive(false);
                if (drop1.transform.GetChild(0).tag == "left")
                {
                    m_Car.Move(h, v, v, handbrake);
                    left = true;
                }
                else if (drop1.transform.GetChild(0).tag == "right")
                {
                    m_Car.Move(-h, v, v, handbrake);
                }
                else
                {
                    m_Car.Move(0, 0, 0, 0);
                }

            }
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}
