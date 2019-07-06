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
        public GameObject drop11;
        public GameObject drop22;
        public GameObject drop33;
        public GameObject drop2;
        public GameObject dragAndDropCanvas;
        public GameObject dragAndDropCanvas2;
        public GameObject dragAndDropCanvas3;
        public GameObject barrier;
        private bool secondCanvasDone;
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
        private bool first_done = false;
        private bool second_done = false;
        public GameObject error;
        private bool stop = false;

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
            //Time.timeScale = 1;
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
            if (stop)
            {
                Time.timeScale = 0;
            }
            m_Car.Move(TURN, FORWARD, FOOTBRAKES, 0);
            //THIS IS FOR THE SECOND CANVAS FIRST DROP
            //THIS IS FOR THE FIRST CANVAS AND THE ONLY DROP DESTINATION
            if (drop11.transform.childCount > 0 & drop22.transform.childCount > 0 & drop33.transform.childCount > 0)
            {
                second_done = true;
                Debug.Log("drop11 and drop 22 and drop 33 are all child count greater than 0");
                //Time.timeScale = 1;
                dragAndDropCanvas2.SetActive(false);
                StartCoroutine(Example3());
                if (drop22.transform.GetChild(0).tag == "if")
                {
                    StartCoroutine(UsingIf());
                }
            }
            if (Physics.Raycast(raycastObject.transform.position, fwd, out objectHit, 15) & first_done & !second_done)
            {
                dragAndDropCanvas2.SetActive(true);
                Time.timeScale = 0;
                Debug.Log("changing timescale");
            }
            if (drop1.transform.childCount > 0 & !first_done)
            {
                Debug.Log("drop1transform");
                Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
                Debug.DrawRay(raycastObject.transform.position, forward, Color.green);
                Debug.Log(Physics.Raycast(raycastObject.transform.position, fwd, out objectHit, 10));
                if (drop1.transform.GetChild(0).tag == "forward" & !Physics.Raycast(raycastObject.transform.position, fwd, out objectHit, 10))
                {
                    Debug.Log("didn't collide");
                    TURN = 0;
                    FORWARD = 100;
                    first_done = true;
                }
                if (drop1.transform.GetChild(0).tag == "left")
                {
                    TURN = (float)-1.5;
                    FORWARD = 100;
                    first_done = true;
                }
                if (drop1.transform.GetChild(0).tag == "right")
                {
                    TURN = (float)1.5;
                    FORWARD = 100;
                    first_done = true;
                }
                Destroy(barrier);
                dragAndDropCanvas.SetActive(false);
                m_Car.Move(TURN, FORWARD, 0, 0);
                m_Car.m_Topspeed = 100;
                //if (drop2.transform.GetChild(0).tag == "right")
                //{
                //    TURN = (float)1.5;
                //    FORWARD = 100;
                //    second_done = true;
                //}
                //if (drop2.transform.GetChild(0).tag == "left")
                //{
                //    TURN = (float)-1.5;
                //    FORWARD = 100;
                //    second_done = true;
                //}
                //if ((drop2.transform.GetChild(0).tag == "forward" & !Physics.Raycast(raycastObject.transform.position, fwd, out objectHit, 5)))
                //{
                //    TURN = 0;
                //    FORWARD = 100;
                //    direction = "forward";
                //    second_done = true;
                //}
      
            }
            if (drop11.transform.childCount > 0 & !secondCanvasDone)
            {
                if (drop11.transform.GetChild(0).tag == "forward")
                {
                    TURN = 0;
                    FORWARD = 100;
                    direction = "forward";
                    first_done = true;
                    Debug.Log("forward drop 11");
                    secondCanvasDone = true;
                }
                else if (drop11.transform.GetChild(0).tag == "left")
                {
                    TURN = (float)-155;
                    FORWARD = 100;
                    first_done = true;
                    Debug.Log("left Drop 11");
                    secondCanvasDone = true;
                }
                else if (drop11.transform.GetChild(0).tag == "right")
                {
                    TURN = (float)155;
                    FORWARD = 100;
                    first_done = true;
                    Debug.Log("right Drop 11");
                    secondCanvasDone = true;
                }
            }
            IEnumerator Example3()
            {
                timeDone3 = false;
                yield return new WaitForSeconds((float)0.9);
                timeDone3 = true;
                if (drop33.transform.GetChild(0).tag == "forward")
                {
                    TURN = 0;
                }
                else if (drop33.transform.GetChild(0).tag == "right")
                {
                    TURN = 155;
                }
                else if (drop33.transform.GetChild(0).tag == "left")
                {
                    TURN = -155;
                }
            }
            IEnumerator UsingIf()
            {
                yield return new WaitForSeconds((float)1);
                TURN = 0;
                FORWARD = 0;
                yield return new WaitForSeconds((float)2);
                Debug.Log("timescale changed to 0");
                stop = true;
            }
#else
            m_Car.Move(h, v, v, 0f);

#endif
        }

    }
}
