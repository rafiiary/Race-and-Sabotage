using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using TMPro;
using System.Collections;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class Move_functions : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        public GameObject drop1;
        public GameObject drop2;
        public GameObject dragAndDropCanvas;
        public GameObject dragAndDropCanvas2;
        public GameObject barrier;
        public static bool correct_input = false;
        bool right = false;
        private bool entered = false;
        private bool timeDone = false;
        private bool timeDone2 = false;
        private bool timeDone3 = false;
        //public GameObject explainCanvas;
        //public GameObject useArrows;
        //public GameObject fixingBug;
        //public GameObject pause;
        //public GameObject glossary;
        //public GameObject setting;
        //public float steering;
        //public float accel;
        private Rigidbody m_Rigidbody;
        public float TURNING = 0;
        private bool noCodingVersion = true;
        public float TURN = 0;
        public float FORWARD = 0;
        private bool if_statement_done;
        public GameObject raycastObject;
        private bool finished_forward = false;
        private float FOOTBRAKES = 0;
        private string direction;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
            m_Rigidbody = GetComponent<Rigidbody>();
            //m_WheelColliders = GetComponent<WheelCollider[]>();
            //pause.SetActive(false);
            //glossary.SetActive(false);
            //setting.SetActive(false);
            TURN = 0;
            FORWARD = 0;
            Time.timeScale = 1;
        }

        private void Update()
        {
            RaycastHit objectHit;
            Vector3 fwd = raycastObject.transform.TransformDirection(Vector3.forward);
            Debug.DrawRay(raycastObject.transform.position, fwd * 10, Color.green);
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            //print("H" + (h * 10000).ToString());
            float v = CrossPlatformInputManager.GetAxis("Vertical");
            //print("V" + v.ToString());
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            //m_Car.Move(5, 2, v, handbrake)
            Debug.Log(FORWARD);
            Debug.Log(TURN);
            if (Physics.Raycast(raycastObject.transform.position, fwd, out objectHit, 10))
            {
                dragAndDropCanvas2.SetActive(true);
                Time.timeScale = 0;
                Debug.Log("changing timescale");
            }
            m_Car.Move(TURN, FORWARD, FOOTBRAKES, 0);
            if (drop1.transform.childCount > 0 & !finished_forward)
            {
                Debug.Log("drop1transform");
                Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
                Debug.DrawRay(raycastObject.transform.position, forward, Color.green);
                Debug.Log(Physics.Raycast(raycastObject.transform.position, fwd, out objectHit, 10));
                if (drop1.transform.GetChild(0).tag == "forward" & !Physics.Raycast(raycastObject.transform.position, fwd, out objectHit, 5))
                {
                    Debug.Log("didn't collide");
                    TURN = 0;
                    FORWARD = 100;
                    direction = "forward";
                }
                if (drop1.transform.GetChild(0).tag == "left")
                {
                    TURN = (float)-1.5;
                    FORWARD = 100;
                }
                if (drop1.transform.GetChild(0).tag == "right")
                {
                    TURN = (float)1.5;
                    FORWARD = 100;
                }
                Destroy(barrier);
                dragAndDropCanvas.SetActive(false);
                m_Car.Move(TURN, FORWARD, 0, 0);
                m_Car.m_Topspeed = 100;
            }
            Debug.Log("before entered the second drag and drop canvas");

            IEnumerator Example2(float time)
            {
                Debug.Log("It reached here2");
                timeDone2 = false;
                yield return new WaitForSeconds((float)time);
                timeDone2 = true;
                Debug.Log("It reached here3" + timeDone2.ToString());
            }
            IEnumerator Example3(float time)
            {
                timeDone3 = false;
                yield return new WaitForSeconds((float)time);
                timeDone3 = true;
                Debug.Log("It reached here4" + timeDone2.ToString());
            }
#else
            m_Car.Move(h, v, v, 0f);

#endif
        }

    }
}
