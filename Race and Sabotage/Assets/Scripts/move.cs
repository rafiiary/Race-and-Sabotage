using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using TMPro;
using System.Collections;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class move : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        public GameObject drop1;
        public GameObject drop2;
        public GameObject dragAndDropCanvas;
        public static bool correct_input = false;
        bool right = false;
        public GameObject countdown;
        public TextMeshProUGUI move_forward;
        public TextMeshProUGUI last_move_forward;
        public TextMeshProUGUI if_statement;
        public TextMeshProUGUI if_content;
        public TextMeshProUGUI if_else;
        public TextMeshProUGUI if_else_content;
        public GameObject watchCodeExecution;
        private bool entered = false;
        private bool timeDone = false;
        private bool timeDone2 = false;
        private bool timeDone3 = false;
        public GameObject explainIfElse;
        public GameObject explainCanvas;
        public GameObject useArrows;
        public GameObject fixingBug;
        public GameObject pause;
        public GameObject glossary;
        public GameObject setting;
        public float steering;
        public float accel;
        private Rigidbody m_Rigidbody;
        private WheelCollider[] m_WheelColliders = new WheelCollider[4];
        public static float TURNING = 0;
        private bool noCodingVersion = true;
        public GameObject preventsRollingDown;
        private float TURN = 0;
        private bool if_statement_done;
        public static bool letCodeExecution = false;
        public GameObject next;
        public GameObject nextCheck;
        public static bool letCodeExecution2 = false;
        public GameObject explaination2;

        private void Awake()
        {
            letCodeExecution = false;
            // get the car controller
            m_Car = GetComponent<CarController>();
            m_Rigidbody = GetComponent<Rigidbody>();
            //m_WheelColliders = GetComponent<WheelCollider[]>();
            move_forward.text = "move_forward();";
            explainIfElse.SetActive(false);
            watchCodeExecution.SetActive(false);
            pause.SetActive(false);
            glossary.SetActive(false);
            setting.SetActive(false);
            explaination2.SetActive(false);
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
            //m_Car.Move(5, 2, v, handbrake)
            Debug.Log(nextCheck.GetComponent<TypeWriter>().done);
            if (drop1.transform.childCount > 0 && drop2.transform.childCount > 0)
            {
                //m_Car.ApplyDrive(2, 0);
                //m_Car.Move(TURNING, 2, 0, 0);
                Destroy(preventsRollingDown);
                m_Car.Move(TURN, 2, 0, 0);
                if (!timeDone2)
                {
                    TURN = 0;
                    move_forward.color = new Color32(255, 128, 0, 255);
                    if_else.color = new Color32(150, 20, 45, 45);
                    if_else_content.color = new Color32(150, 20, 45, 45);
                    if_statement.color = new Color32(150, 20, 45, 45);
                    if_content.color = new Color32(150, 20, 45, 45);
                    last_move_forward.color = new Color32(150, 20, 45, 45);
                }
                //debug.log("It reached here");
                if (timeDone2)
                {
                    //debug.log("TURN!!!!" + correct_input.ToString());
                    if (correct_input)
                    {
                        TURN = -1;
                    }
                    else
                    {
                        TURN = 1;

                    }
                    move_forward.color = new Color32(150, 20, 45, 45);
                    if (!entered)
                    {
                        if_statement.color = new Color32(255, 128, 0, 255);
                        StartCoroutine(Example((float)0.2));
                        // using time.timescale doesn't work because the showpanel will make it back to time.timescale = 1 
                        explainIfElse.SetActive(true);
                        next.SetActive(true);
                        ShowPanel.paused = true;
                        letCodeExecution = true;
                        watchCodeExecution.SetActive(true);
                        Debug.Log(nextCheck.GetComponent<TypeWriter>().done);
                        entered = true;
                    }
                    else if (timeDone)
                    {
                        if_statement.color = new Color32(150, 20, 45, 45);
                        if_content.color = new Color32(150, 20, 45, 45);
                        if_else.color = new Color32(255, 128, 0, 255);
                        if_else_content.color = new Color32(255, 128, 0, 255);
                        if_statement_done = true;
                    }
                    if (timeDone3)
                    {
                        TURN = 0;
                        if (NextButton.count == 1)
                        {
                            explaination2.SetActive(true);
                            next.transform.position = new Vector3(next.transform.position.x, explaination2.transform.position.y - 100, next.transform.position.z);
                            next.SetActive(true);
                            ShowPanel.paused = true;
                            letCodeExecution2 = true;
                        }
                        watchCodeExecution.SetActive(true);
                        if (NextButton.count == 2)
                        {
                            if_else.color = new Color32(150, 20, 45, 45);
                            if_else_content.color = new Color32(150, 20, 45, 45);
                            if_statement.color = new Color32(150, 20, 45, 45);
                            if_content.color = new Color32(150, 20, 45, 45);
                            last_move_forward.color = new Color32(255, 128, 0, 255);
                        }
                        m_Car.Move(0, 2, 0, 0);
                    }
                }
                if (!timeDone2)
                {
                    StartCoroutine(Example2(17));
                }
                if (!timeDone3)
                {
                    StartCoroutine(Example3((float)18));
                }

                dragAndDropCanvas.SetActive(false);
                //if (countdown.active == false)
                //{
                //    StartCoroutine(Example((float)3));
                //   useArrows.SetActive(true);
                //}
                //steering = Mathf.Clamp(1, -1, 1);
                //accel = Mathf.Clamp(100, 0, 1);
                //m_Car.ApplyDrive(100, 0);
                //m_WheelColliders[0].steerAngle = 10;
                //m_WheelColliders[1].steerAngle = 10;
                if (drop1.transform.GetChild(0).tag == "right")
                {
                    //m_Car.ApplyDrive(2,0);
                    ClickRight.turn = 4;
                    //m_Car.Move(5, 2, v, handbrake);  // comment out
                    correct_input = true;
                }
                else if (drop1.transform.GetChild(0).tag == "left")
                {
                    //m_Car.Move(-5, 2, v, handbrake); // comment out 
                    //m_Car.ApplyDrive(2, 0);
                    ClickRight.turn = -4;
                    correct_input = false;

                }
                else
                {
                    //m_Car.Move(0, 0, 0, 0);
                    correct_input = false;
                }
                if_content.text = "<color=#2DA22D>" + drop1.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text.Split('>')[1] + "}";
                if_else_content.text = "<color=#26B7B1>" + drop2.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text.Split('>')[1] + "}";

            }
            if (fixingBug.active == true)
            {
                watchCodeExecution.SetActive(true);
                pause.SetActive(true);
                glossary.SetActive(true);
                setting.SetActive(true);
            }
            //if (watchCodeExecution.active == true && ClickLeft.left_clicked)
            //{
            //    // to make it dull use (150, 20, 45, 45), for it to be dark, use (255, 128, 0, 255)
            //    if_else.color = new Color32(150, 20, 45, 45);
            //    if_else_content.color = new Color32(150, 20, 45, 45);
            //    if_statement.color = new Color32(255, 128, 0, 255);
            //    if_content.color = new Color32(255, 128, 0, 255);
            //    entered = false;
            //}
            //else if (watchCodeExecution.active == true && ClickRight.right_clicked)
            //{
            //    ////debug.log("entered" + entered.ToString());
            //    if (!entered)
            //    {
            //        //debug.log("entered");
            //        explainIfElse.SetActive(true);
            //        if_statement.color = new Color32(255, 128, 0, 255);
            //        StartCoroutine(Example((float)0.1));
            //        entered = true;
            //    }
            //    if (timeDone)
            //    {
            //        if_statement.color = new Color32(150, 20, 45, 45);
            //        if_content.color = new Color32(150, 20, 45, 45);
            //        if_else.color = new Color32(255, 128, 0, 255);
            //        if_else_content.color = new Color32(255, 128, 0, 255);
            //    }
            //}
            //else
            //{
            //    if_content.color = new Color32(150, 20, 45, 45);
            //    if_statement.color = new Color32(150, 20, 45, 45);
            //    if_else.color = new Color32(150, 20, 45, 45);
            //    if_else_content.color = new Color32(150, 20, 45, 45);
            //    entered = false;
            //}
            IEnumerator Example(float time)
            {
                timeDone = false;
                yield return new WaitForSeconds((float)time);
                timeDone = true;
                entered = true;
            }

            IEnumerator Example2(float time)
            {
                //debug.log("It reached here2");
                timeDone2 = false;
                yield return new WaitForSeconds((float)time);
                timeDone2 = true;
                //debug.log("It reached here3" + timeDone2.ToString());
            }
            IEnumerator Example3(float time)
            {
                timeDone3 = false;
                yield return new WaitForSeconds((float)time);
                timeDone3 = true;
                //debug.log("It reached here4" + timeDone2.ToString());
            }
#else
            m_Car.Move(h, v, v, 0f);

#endif
        }

    }
}






//////////////////////////////
///








//using System;
//using UnityEngine;
//using UnityStandardAssets.CrossPlatformInput;
//using TMPro;
//using System.Collections;
//using UnityStandardAssets.Utility;
//using UnityStandardAssets.Vehicles.Car;

//namespace UnityStandardAssets.Vehicles.Car
//{
//    [RequireComponent(typeof(CarController))]
//    public class move : MonoBehaviour
//    {
//        private CarController m_Car; // the car controller we want to use
//        public GameObject drop1;
//        public GameObject drop2;
//        public GameObject dragAndDropCanvas;
//        public static bool correct_input = false;
//        bool right = false;
//        public GameObject countdown;
//        public TextMeshProUGUI move_forward;
//        public TextMeshProUGUI last_move_forward;
//        public TextMeshProUGUI if_statement;
//        public TextMeshProUGUI if_content;
//        public TextMeshProUGUI if_else;
//        public TextMeshProUGUI if_else_content;
//        public GameObject watchCodeExecution;
//        private bool entered = false;
//        private bool timeDone = false;
//        private bool timeDone2 = false;
//        private bool timeDone3 = false;
//        public GameObject explainIfElse;
//        public GameObject explainCanvas;
//        public GameObject useArrows;
//        public GameObject fixingBug;
//        public GameObject pause;
//        public GameObject glossary;
//        public GameObject setting;
//        public float steering;
//        public float accel;
//        private Rigidbody m_Rigidbody;
//        private WheelCollider[] m_WheelColliders = new WheelCollider[4];
//        public static float TURNING = 0;
//        private bool noCodingVersion = true;
//        public GameObject preventsRollingDown;
//        private float TURN = 0;
//        private bool if_statement_done;


//        public WaypointCircuit correctcircuit;
//        public WaypointCircuit wrongcircuit;
//        public GameObject WaypointTargetObject;




//        private void Awake()
//        {
//            // get the car controller
//            m_Car = GetComponent<CarController>();
//            m_Rigidbody = GetComponent<Rigidbody>();
//            //m_WheelColliders = GetComponent<WheelCollider[]>();
//            move_forward.text = "move_forward();";
//            explainIfElse.SetActive(false);
//            watchCodeExecution.SetActive(false);
//            pause.SetActive(false);
//            glossary.SetActive(false);
//            setting.SetActive(false);
//        }

//        private void FixedUpdate()
//        {
//            if (drop1.transform.childCount > 0 && drop2.transform.childCount > 0)
//            {
//                Destroy(preventsRollingDown);
//                m_Car.Move(TURN, 2, 0, 0);

//                if (!timeDone2)
//                {
//                    TURN = 0;
//                    move_forward.color = new Color32(255, 128, 0, 255);
//                    if_else.color = new Color32(150, 20, 45, 45);
//                    if_else_content.color = new Color32(150, 20, 45, 45);
//                    if_statement.color = new Color32(150, 20, 45, 45);
//                    if_content.color = new Color32(150, 20, 45, 45);
//                    last_move_forward.color = new Color32(150, 20, 45, 45);


//                    StartCoroutine(Example2((float)17));


//                }
//                if (timeDone2)
//                {
//                    //debug.log("TURN!!!!" + correct_input.ToString());
//                    if (correct_input)
//                    {
//                        //TURN = -1;
//                        gameObject.AddComponent<CarAIControl>();
//                        gameObject.AddComponent<WaypointProgressTracker>();

//                        CarAIControl aiControl = GetComponent<CarAIControl>();
//                        aiControl.m_Driving = true;
//                        aiControl.SetStopWhenTargetReached(false);

//                        WaypointProgressTracker wpt = GetComponent<WaypointProgressTracker>();
//                        wpt.circuit = correctcircuit;
//                        wpt.target = WaypointTargetObject.transform;

//                    }
//                    else
//                    {
//                        //TURN = 1;
//                        gameObject.AddComponent<CarAIControl>();
//                        gameObject.AddComponent<WaypointProgressTracker>();

//                        CarAIControl aiControl = GetComponent<CarAIControl>();
//                        aiControl.m_Driving = true;
//                        aiControl.SetStopWhenTargetReached(false);

//                        WaypointProgressTracker wpt = GetComponent<WaypointProgressTracker>();
//                        wpt.circuit = wrongcircuit;
//                        wpt.target = WaypointTargetObject.transform;

//                    }
//                    move_forward.color = new Color32(150, 20, 45, 45);
//                    if (!entered)
//                    {
//                        if_statement.color = new Color32(255, 128, 0, 255);
//                        StartCoroutine(Example((float)0.2));
//                        explainIfElse.SetActive(true);
//                    }
//                    else if (timeDone)
//                    {
//                        if_statement.color = new Color32(150, 20, 45, 45);
//                        if_content.color = new Color32(150, 20, 45, 45);
//                        if_else.color = new Color32(255, 128, 0, 255);
//                        if_else_content.color = new Color32(255, 128, 0, 255);
//                        if_statement_done = true;
//                    }
//                    if (timeDone3)
//                    {
//                        //TURN = 0;
//                        if_else.color = new Color32(150, 20, 45, 45);
//                        if_else_content.color = new Color32(150, 20, 45, 45);
//                        if_statement.color = new Color32(150, 20, 45, 45);
//                        if_content.color = new Color32(150, 20, 45, 45);
//                        last_move_forward.color = new Color32(255, 128, 0, 255);
//                        //m_Car.Move(0, 2, 0, 0);
//                    }
//                }

//                if (!timeDone3)
//                {
//                    StartCoroutine(Example3((float)18));
//                }





//                // ENUMERATORS THAT ARE RUN THROUGH COROUTINES

//                IEnumerator Example(float time)
//                {
//                    timeDone = false;
//                    yield return new WaitForSeconds((float)time);
//                    timeDone = true;
//                    entered = true;
//                }

//                IEnumerator Example2(float time)
//                {
//                    //debug.log("It reached here2");
//                    timeDone2 = false;
//                    yield return new WaitForSeconds((float)time);
//                    timeDone2 = true;
//                    //debug.log("It reached here3" + timeDone2.ToString());
//                }
//                IEnumerator Example3(float time)
//                {
//                    timeDone3 = false;
//                    yield return new WaitForSeconds((float)time);
//                    timeDone3 = true;
//                    //debug.log("It reached here4" + timeDone2.ToString());
//                }
//            }
//        }
//    }
//}

