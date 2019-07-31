using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using TMPro;
using System.Collections;
using UnityStandardAssets.Utility;
using UnityStandardAssets.Vehicles.Car;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class MoveNew : MonoBehaviour
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


        public WaypointCircuit correctcircuit;
        public WaypointCircuit wrongcircuit;
        public GameObject WaypointTargetObject;




        private void Awake()
        {
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
        }

        private void FixedUpdate()
        {
            if (drop1.transform.childCount > 0 && drop2.transform.childCount > 0)
            {
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


                    StartCoroutine(Example2((float)17));


                }
                if (timeDone2)
                {
                    ////debug.log("TURN!!!!" + correct_input.ToString());
                    if (correct_input)
                    {
                        //TURN = -1;
                        gameObject.AddComponent<CarAIControl>();
                        gameObject.AddComponent<WaypointProgressTracker>();

                        CarAIControl aiControl = GetComponent<CarAIControl>();
                        aiControl.m_Driving = true;
                        aiControl.SetStopWhenTargetReached(false);

                        WaypointProgressTracker wpt = GetComponent<WaypointProgressTracker>();
                        wpt.circuit = correctcircuit;
                        wpt.target = WaypointTargetObject.transform;

                    }
                    else
                    {
                        //TURN = 1;
                        gameObject.AddComponent<CarAIControl>();
                        gameObject.AddComponent<WaypointProgressTracker>();

                        CarAIControl aiControl = GetComponent<CarAIControl>();
                        aiControl.m_Driving = true;
                        aiControl.SetStopWhenTargetReached(false);

                        WaypointProgressTracker wpt = GetComponent<WaypointProgressTracker>();
                        wpt.circuit = wrongcircuit;
                        wpt.target = WaypointTargetObject.transform;

                    }
                    move_forward.color = new Color32(150, 20, 45, 45);
                    if (!entered)
                    {
                        if_statement.color = new Color32(255, 128, 0, 255);
                        StartCoroutine(Example((float)0.2));
                        explainIfElse.SetActive(true);
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
                        //TURN = 0;
                        if_else.color = new Color32(150, 20, 45, 45);
                        if_else_content.color = new Color32(150, 20, 45, 45);
                        if_statement.color = new Color32(150, 20, 45, 45);
                        if_content.color = new Color32(150, 20, 45, 45);
                        last_move_forward.color = new Color32(255, 128, 0, 255);
                        //m_Car.Move(0, 2, 0, 0);
                    }
                }

                if (!timeDone3)
                {
                    StartCoroutine(Example3((float)18));
                }





                // ENUMERATORS THAT ARE RUN THROUGH COROUTINES

                IEnumerator Example(float time)
                {
                    timeDone = false;
                    yield return new WaitForSeconds((float)time);
                    timeDone = true;
                    entered = true;
                }

                IEnumerator Example2(float time)
                {
                    ////debug.log("It reached here2");
                    timeDone2 = false;
                    yield return new WaitForSeconds((float)time);
                    timeDone2 = true;
                    ////debug.log("It reached here3" + timeDone2.ToString());
                }
                IEnumerator Example3(float time)
                {
                    timeDone3 = false;
                    yield return new WaitForSeconds((float)time);
                    timeDone3 = true;
                    ////debug.log("It reached here4" + timeDone2.ToString());
                }
            }
        }
    }
}
