using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using TMPro;
using System.Collections;
using System.Collections.Generic;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class ForLoop2 : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        public GameObject LeftBracketDrop;
        public GameObject RightBracketDrop;
        public GameObject VariableDrop;
        public GameObject LoopDrop;
        public GameObject dragAndDropCanvas;
        public static bool correct_input = false;
        bool right = false;
        //public GameObject countdown;
        public TextMeshProUGUI move_forward;
        public TextMeshProUGUI lst;
        public TextMeshProUGUI forLoop;
        public TextMeshProUGUI forLoopContent;
        public TextMeshProUGUI ActualCountDown;
        public GameObject CanvasActualCountdownIsOn;
        public GameObject watchCodeExecution;
        public TextMeshProUGUI feedback;
        private bool entered = false;
        private bool timeDone = false;
        private bool timeDone2 = false;
        private bool timeDone3 = false;
        private bool timeDone4 = true;
        private bool timeDone5 = false;
        public float accel;
        private Rigidbody m_Rigidbody;
        private WheelCollider[] m_WheelColliders = new WheelCollider[4];
        public static float TURNING = 0;
        private bool noCodingVersion = true;
        public GameObject preventsRollingDown;
        private float TURN = 0;
        private bool if_statement_done;
        public GameObject winCanvas;
        public GameObject loseCanvas;
        private bool No_moneyYet = false;
        public GameObject Pause;
        private bool change_if_content = true;
        private bool drive = false;
        private int timer = 10;
        private int secondTimer = 5;
        public GameObject errorMessage;
        public TextMeshProUGUI errorMessageText;
        private bool attemptedOnce = false;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
            watchCodeExecution.SetActive(false);
            lst.color = new Color32(150, 20, 45, 45);
            move_forward.color = new Color32(150, 20, 45, 45);
            forLoop.color = new Color32(150, 20, 45, 45);
            forLoopContent.color = new Color32(150, 20, 45, 45);
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
            //m_Car.Move(5, 2, v, handbrake)
            if (LeftBracketDrop.transform.childCount > 0 & RightBracketDrop.transform.childCount > 0 & VariableDrop.transform.childCount > 0 & LoopDrop.transform.childCount > 0)
            {
                Debug.Log(LoopDrop.transform.GetChild(0).tag);
                if (!attemptedOnce)
                {
                    attemptedOnce = true;
                    Debug.Log("all the drops have more than one input now");
                    if (LeftBracketDrop.transform.GetChild(0).tag == "[" & RightBracketDrop.transform.GetChild(0).tag == "]")
                    {
                    }
                    else if (LeftBracketDrop.transform.GetChild(0).tag == "{" || LeftBracketDrop.transform.GetChild(0).tag == "}" || RightBracketDrop.transform.GetChild(0).tag == "}" || RightBracketDrop.transform.GetChild(0).tag == "{")
                    {
                        errorMessage.SetActive(true);
                        errorMessageText.text = "'{}' are used for the start and end of a loop whereas lists use '[]'";
                        StartCoroutine(error());
                    }
                    else
                    {
                        errorMessage.SetActive(true);
                        errorMessageText.text = "The TimerCounter needs to be in a list.";
                        StartCoroutine(error());
                    }
                    if (VariableDrop.transform.GetChild(0).tag != "GameController")
                    {
                        errorMessage.SetActive(true);
                        errorMessageText.text = "You need a VARIABLE to go through the list eg. number";
                        StartCoroutine(error());
                    }
                    if (LoopDrop.transform.GetChild(0).tag == "+2" || LoopDrop.transform.GetChild(0).tag == "-2" || LoopDrop.transform.GetChild(0).tag == "-1")
                    {
                        errorMessage.SetActive(false);
                        errorMessageText.text = "no";
                    }
                    else
                    {
                        errorMessage.SetActive(true);
                        errorMessageText.text = "Invalid input inside the loop. Try again.";
                        StartCoroutine(error());
                    }
                    //{
                    //    errorMessage.SetActive(true);
                    //    errorMessageText.text = "YAY.";
                    //    StartCoroutine(error());
                    //}
                    //else
                    //{
                    //    errorMessage.SetActive(true);
                    //    errorMessageText.text = "Invalid input inside the loop. Try again.";
                    //    StartCoroutine(error());
                    //}

                    //Pause.SetActive(true);
                    if (!entered)
                    {
                        //StartCoroutine(CountdownTimer());
                    }
                    Debug.Log(timeDone.ToString() + "timeDone");
                    Debug.Log(timeDone2.ToString() + "timeDone2");
                    //dragAndDropCanvas.SetActive(false);
                    watchCodeExecution.SetActive(true);
                    if (drive)
                    {
                        if (timer != 0)
                        {
                            m_Car.Move(0, 2, 0, 0);
                        }
                        timer--;
                        lst.color = new Color32(150, 20, 45, 45);
                        forLoop.color = new Color32(150, 20, 45, 45);
                        forLoopContent.color = new Color32(150, 20, 45, 45);

                    }
                }
            }
            else
            {
                attemptedOnce = false;
            }

#else
            m_Car.Move(h, v, v, 0f);

#endif
        }
        IEnumerator error()
        {
            yield return new WaitForSeconds((float)2);
            errorMessage.SetActive(false);
        }
        //IEnumerator CountdownTimer()
        //{
        //    entered = true;
        //    //colouring the list
        //    lst.color = new Color32(255, 128, 0, 255);
        //    yield return new WaitForSeconds((float)0.2);
        //    //starting the loop colouring
        //    forLoop.color = new Color32(255, 128, 0, 255);
        //    yield return new WaitForSeconds((float)1);
        //    forLoop.color = new Color32(150, 20, 45, 45);
        //    forLoopContent.color = new Color32(255, 128, 0, 255);
        //    yield return new WaitForSeconds((float)1);
        //    //second number
        //    forLoop.color = new Color32(255, 128, 0, 255);
        //    forLoopContent.color = new Color32(150, 20, 45, 45);
        //    yield return new WaitForSeconds((float)1);
        //    forLoop.color = new Color32(150, 20, 45, 45);
        //    forLoopContent.color = new Color32(255, 128, 0, 255);
        //    yield return new WaitForSeconds((float)1);
        //    //third number
        //    forLoop.color = new Color32(255, 128, 0, 255);
        //    forLoopContent.color = new Color32(150, 20, 45, 45);
        //    yield return new WaitForSeconds((float)1);
        //    forLoop.color = new Color32(150, 20, 45, 45);
        //    forLoopContent.color = new Color32(255, 128, 0, 255);
        //    yield return new WaitForSeconds((float)1);
        //    drive = true;
        //    CanvasActualCountdownIsOn.SetActive(false);
        //    move_forward.color = new Color32(255, 128, 0, 255);
        //    yield return new WaitForSeconds((float)3);
        //    move_forward.color = new Color32(150, 20, 45, 45);
        //    winCanvas.SetActive(true);
        //}
    }
}
