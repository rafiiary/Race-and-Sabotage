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
        public GameObject loseCanvas;
        public TextMeshProUGUI feedback;
        public GameObject feedback_object;
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
        private bool syntax = false;
        private int count = 30;

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
            m_Car.Move(TURN, FORWARD, FOOTBRAKES, FOOTBRAKES);
            //THIS IS FOR THE SECOND CANVAS FIRST DROP
            //THIS IS FOR THE FIRST CANVAS AND THE ONLY DROP DESTINATION
            if (drop11.transform.childCount > 0 & drop22.transform.childCount > 0 & drop33.transform.childCount > 0)
            {
                if((drop22.transform.GetChild(0).tag == "left"|| drop22.transform.GetChild(0).tag == "right"|| drop22.transform.GetChild(0).tag == "forward"|| drop11.transform.GetChild(0).tag == "if" || drop11.transform.GetChild(0).tag == "while" || drop33.transform.GetChild(0).tag == "if" || drop33.transform.GetChild(0).tag == "while"))
                {
                    //loseCanvas.SetActive(true);
                    feedback.text = "Syntax Error: this combination doesn't make sense";
                    if (!syntax)
                    {
                        feedback_object.SetActive(true);
                        if (count != 0)
                        {
                            count --;
                        }
                    }
                    if (count == 0)
                    {
                        feedback_object.SetActive(false);
                        syntax = true;
                    }
                    //dragAndDropCanvas2.SetActive(false);
                    if (drop22.transform.GetChild(0).tag == "left" || drop22.transform.GetChild(0).tag == "right" || drop22.transform.GetChild(0).tag == "forward")
                    {
                        drop22.GetComponent<wobble>().enabled = true;
                    }
                    if (drop11.transform.GetChild(0).tag == "if" || drop11.transform.GetChild(0).tag == "while")
                    {
                        drop11.GetComponent<wobble>().enabled = true;
                    }
                    if (drop33.transform.GetChild(0).tag == "if" || drop33.transform.GetChild(0).tag == "while")
                    {
                        drop33.GetComponent<wobble>().enabled = true;
                    }
                    Time.timeScale = 0;
                    return;
                }
                second_done = true;
                Debug.Log("drop11 and drop 22 and drop 33 are all child count greater than 0");
                //Time.timeScale = 1;
                dragAndDropCanvas2.SetActive(false);
                StartCoroutine(Example3());
            }
            else
            {
                drop11.GetComponent<wobble>().enabled = false;
                drop22.GetComponent<wobble>().enabled = false;
                drop33.GetComponent<wobble>().enabled = false;
                syntax = false;
                count = 30; 
            }
            if (Physics.Raycast(raycastObject.transform.position, fwd, out objectHit, 15) & first_done & !second_done)
            {
                dragAndDropCanvas2.SetActive(true);
                Time.timeScale = 0;
                Debug.Log("changing timescale");
            }
            if (Physics.Raycast(raycastObject.transform.position, fwd, out objectHit, 2) & first_done & !second_done)
            {
                dragAndDropCanvas2.SetActive(true);
                Time.timeScale = 0;
                Debug.Log("changing timescale");
                loseCanvas.SetActive(true);
                feedback.text = "You almost crashed! Try a different combination.";
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
                //if (drop22.transform.GetChild(0).tag == "if")
                //{
                //    StartCoroutine(UsingIf());
                //}
            }
            IEnumerator Example3()
            {
                timeDone3 = false;
                yield return new WaitForSeconds((float)1);
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
                    TURN = -15;
                }
                if (drop22.transform.GetChild(0).tag == "if")
                {
                    StartCoroutine(UsingIf());
                }
            }
            IEnumerator UsingIf()
            {
                yield return new WaitForSeconds((float)1);
                TURN = 0;
                FORWARD = 0;
                yield return new WaitForSeconds((float)2);
                Debug.Log("timescale changed to 0");
                //stop = true;
                FOOTBRAKES = 100000000;
                yield return new WaitForSeconds((float)0.5);
                loseCanvas.SetActive(true);
                feedback.text = "If statements only loop once!";
                Debug.Log("why isn't the lose canvas active???");
            }
            IEnumerator SyntaxError()
            {
                Debug.Log("before syntax error");
                yield return new WaitForSeconds((float)0.0);
                Debug.Log("after syntax error");
            }
#else
            m_Car.Move(h, v, v, 0f);

#endif
        }

    }
}
