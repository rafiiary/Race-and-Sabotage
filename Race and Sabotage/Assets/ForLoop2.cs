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
        private float parsedFloat;

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
            ////print("H" + (h * 10000).ToString());
            float v = CrossPlatformInputManager.GetAxis("Vertical");
            ////print("V" + v.ToString());
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            //m_Car.Move(5, 2, v, handbrake)
            if(drive)
            {
                m_Car.Move(0, 2, 0, 0);
            }
            else
            {
                m_Car.Move(0, 0,0,0);
            }
            if (LeftBracketDrop.transform.childCount > 0 & RightBracketDrop.transform.childCount > 0 & VariableDrop.transform.childCount > 0 & LoopDrop.transform.childCount > 0)
            {
                ////debug.log(LoopDrop.transform.GetChild(0).tag);
                if (!attemptedOnce)
                {
                    attemptedOnce = true;
                    ////debug.log("all the drops have more than one input now");
                    // THIS WILL FIRST CHECK THE BRACKETS AND IF CORRECT, CHECK THE VARIABLE AND THEN CHECK THE INNER LOOP
                    if (LeftBracketDrop.transform.GetChild(0).tag == "[" & RightBracketDrop.transform.GetChild(0).tag == "]")
                    {
                        errorMessage.SetActive(false);
                        if (VariableDrop.transform.GetChild(0).tag != "GameController")
                        {
                            errorMessage.SetActive(true);
                            errorMessageText.text = "Use a VARIABLE to go through the list (eg. number)";
                            StartCoroutine(error());
                            StartCoroutine(variableFlash());
                        }
                        else
                        {
                            // ONLY WHEN THE VARIABLE NAME HAS BEEN SET, WILL THE DRAG AND DROP CHECK FOR INSIDE THE LOOP
                            if (LoopDrop.transform.GetChild(0).tag == "+2" || LoopDrop.transform.GetChild(0).tag == "-2" || LoopDrop.transform.GetChild(0).tag == "-1")
                            {
                                // when the player gets everything correct
                                dragAndDropCanvas.SetActive(false);
                                StartCoroutine(CountdownTimer());
                            }
                            else
                            {
                                errorMessage.SetActive(true);
                                errorMessageText.text = "Inside for-loop: You must manipulate the variable 'number'.";
                                StartCoroutine(error());
                                StartCoroutine(loopFlash());
                            }
                        }
                    }
                    else if (LeftBracketDrop.transform.GetChild(0).tag == "leftBracket" || LeftBracketDrop.transform.GetChild(0).tag == "rightBracket" || RightBracketDrop.transform.GetChild(0).tag == "leftBracket" || RightBracketDrop.transform.GetChild(0).tag == "rightBracket")
                    {
                        errorMessage.SetActive(true);
                        errorMessageText.text = "'{ }': used to start/end a loop. Lists use '[ ]'";
                        StartCoroutine(error());
                        StartCoroutine(BracketFlash());
                    }
                    else
                    {
                        errorMessage.SetActive(true);
                        errorMessageText.text = "TimerCounter needs to be in a list.";
                        StartCoroutine(error());
                        StartCoroutine(BracketFlash());
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
                    ////debug.log(timeDone.ToString() + "timeDone");
                    ////debug.log(timeDone2.ToString() + "timeDone2");
                    //dragAndDropCanvas.SetActive(false);
                    if (dragAndDropCanvas.active == false)
                    {
                        watchCodeExecution.SetActive(true);
                    }
                    //if (drive)
                    //{
                    //    if (timer != 0)
                    //    {
                    //        m_Car.Move(0, 2, 0, 0);
                    //    }
                    //    timer--;
                    //    lst.color = new Color32(150, 20, 45, 45);
                    //    forLoop.color = new Color32(150, 20, 45, 45);
                    //    forLoopContent.color = new Color32(150, 20, 45, 45);

                    //}
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
            yield return new WaitForSeconds((float)2.5);
            errorMessage.SetActive(false);
        }
        IEnumerator BracketFlash()
        {
            yield return new WaitForSeconds((float)2.6);
            LeftBracketDrop.transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color32(150, 20, 45, 45);
            RightBracketDrop.transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color32(150, 20, 45, 45);
            ////debug.log(LeftBracketDrop.transform.GetChild(0).transform.GetChild(0).tag);
            yield return new WaitForSeconds((float)0.5);
            LeftBracketDrop.transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color32(255, 128, 0, 255);
            RightBracketDrop.transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color32(255, 128, 0, 255);
            yield return new WaitForSeconds((float)0.5);
            LeftBracketDrop.transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color32(150, 20, 45, 45);
            RightBracketDrop.transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color32(150, 20, 45, 45);
            yield return new WaitForSeconds((float)0.5);
            RightBracketDrop.transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color32(255, 128, 0, 255);
            LeftBracketDrop.transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color32(255, 128, 0, 255);
        }
        IEnumerator variableFlash()
        {
            yield return new WaitForSeconds((float)2.6);
            VariableDrop.transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color32(150, 20, 45, 45);
            ////debug.log(LeftBracketDrop.transform.GetChild(0).transform.GetChild(0).tag);
            yield return new WaitForSeconds((float)0.5);
            VariableDrop.transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color32(255, 128, 0, 255);
            yield return new WaitForSeconds((float)0.5);
            VariableDrop.transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color32(150, 20, 45, 45);
            yield return new WaitForSeconds((float)0.5);
            VariableDrop.transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color32(255, 128, 0, 255);
        }
        IEnumerator loopFlash()
        {
            yield return new WaitForSeconds((float)2.6);
            LoopDrop.transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color32(150, 20, 45, 45);
            ////debug.log(LeftBracketDrop.transform.GetChild(0).transform.GetChild(0).tag);
            yield return new WaitForSeconds((float)0.5);
            LoopDrop.transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color32(255, 128, 0, 255);
            yield return new WaitForSeconds((float)0.5);
            LoopDrop.transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color32(150, 20, 45, 45);
            yield return new WaitForSeconds((float)0.5);
            LoopDrop.transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color32(255, 128, 0, 255);
        }
        IEnumerator CountdownTimer()
        {
            parsedFloat = float.Parse(LoopDrop.transform.GetChild(0).tag);
            forLoopContent.text = "    <color=#C83030>   print(number " + LoopDrop.transform.GetChild(0).tag + "); " +
                "}";
            entered = true;
            //colouring the list
            lst.color = new Color32(255, 128, 0, 255);
            yield return new WaitForSeconds((float)0.2);
            //starting the loop colouring
            forLoop.color = new Color32(255, 128, 0, 255);
            yield return new WaitForSeconds((float)1);
            forLoop.color = new Color32(150, 20, 45, 45);
            forLoopContent.color = new Color32(255, 128, 0, 255);
            ActualCountDown.text = (1 + parsedFloat).ToString();
            yield return new WaitForSeconds((float)1);
            //second number
            forLoop.color = new Color32(255, 128, 0, 255);
            forLoopContent.color = new Color32(150, 20, 45, 45);
            yield return new WaitForSeconds((float)1);
            forLoop.color = new Color32(150, 20, 45, 45);
            forLoopContent.color = new Color32(255, 128, 0, 255);
            ActualCountDown.text = (parsedFloat).ToString();
            yield return new WaitForSeconds((float)1);
            //third number
            forLoop.color = new Color32(255, 128, 0, 255);
            forLoopContent.color = new Color32(150, 20, 45, 45);
            yield return new WaitForSeconds((float)1);
            forLoop.color = new Color32(150, 20, 45, 45);
            forLoopContent.color = new Color32(255, 128, 0, 255);
            ActualCountDown.text = (-1 + parsedFloat).ToString();
            yield return new WaitForSeconds((float)1);
            drive = true;
            CanvasActualCountdownIsOn.SetActive(false);
            move_forward.color = new Color32(255, 128, 0, 255);
            forLoopContent.color = new Color32(150, 20, 45, 45);
            yield return new WaitForSeconds((float)1.4);
            move_forward.color = new Color32(150, 20, 45, 45);
            drive = false;
            if (parsedFloat + 1 == 3 & parsedFloat == 2 & parsedFloat - 1 == 1)
            {
                winCanvas.SetActive(true);
            }
            else
            {
                loseCanvas.SetActive(true);
            }
        }
    }
}
