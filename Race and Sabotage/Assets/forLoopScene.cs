using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using TMPro;
using System.Collections;
using System.Collections.Generic;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class forLoopScene : MonoBehaviour
    {
        public Canvas pausecanvas;
        private CarController m_Car; // the car controller we want to use
        public GameObject drop1;
        public GameObject drop2;
        public GameObject drop3;
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
            if (drop1.transform.childCount > 0 & drop2.transform.childCount > 0 & drop3.transform.childCount > 0)
            {
                ////debug.log(drop1.transform.childCount > 0);
                ////debug.log(drop2.transform.childCount > 0);
                ////debug.log(drop3.transform.childCount > 0);
                if (change_if_content)
                {
                    change_if_content = false;
                    List<float> countdownlist = new List<float>();
                    countdownlist.Add(float.Parse(drop3.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text));
                    countdownlist.Add(float.Parse(drop2.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text));
                    countdownlist.Add(float.Parse(drop1.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text));
                    ////debug.log(countdownlist);
                    lst.text = lst.text + drop3.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text + drop2.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text + drop1.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text + "]";
                    if ((drop3.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text == "3" & drop2.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text == "2" & drop1.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text == "1") || (drop3.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text == "1" & drop2.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text == "2" & drop1.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text == "3"))
                    {
                        feedback.text = "Nice Timer!";
                    }
                }
                //Pause.SetActive(true);
                if (!entered)
                {
                    StartCoroutine(CountdownTimer());
                }
                ////debug.log(timeDone.ToString() + "timeDone");
                ////debug.log(timeDone2.ToString() + "timeDone2");
                dragAndDropCanvas.SetActive(false);
                watchCodeExecution.SetActive(true);
                if(drive)
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

#else
            m_Car.Move(h, v, v, 0f);

#endif
        }
        IEnumerator CountdownTimer()
        {
            pausecanvas.gameObject.SetActive(true);
            entered = true;
            //colouring the list
            lst.color = new Color32(255, 128, 0, 255);
            yield return new WaitForSeconds((float)0.2);
            //starting the loop colouring
            forLoop.color = new Color32(255, 128, 0, 255);
            yield return new WaitForSeconds((float)1);
            forLoop.color = new Color32(150, 20, 45, 45);
            forLoopContent.color = new Color32(255, 128, 0, 255);
            ////debug.log(drop3.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text);
            ActualCountDown.text = drop3.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text;
            yield return new WaitForSeconds((float)1);
            //second number
            forLoop.color = new Color32(255, 128, 0, 255);
            forLoopContent.color = new Color32(150, 20, 45, 45);
            yield return new WaitForSeconds((float)1);
            forLoop.color = new Color32(150, 20, 45, 45);
            forLoopContent.color = new Color32(255, 128, 0, 255);
            ////debug.log(drop2.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text);
            ActualCountDown.text = drop2.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text;
            yield return new WaitForSeconds((float)1);
            //third number
            forLoop.color = new Color32(255, 128, 0, 255);
            forLoopContent.color = new Color32(150, 20, 45, 45);
            yield return new WaitForSeconds((float)1);
            ////debug.log(drop1.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text);
            forLoop.color = new Color32(150, 20, 45, 45);
            forLoopContent.color = new Color32(255, 128, 0, 255);
            ActualCountDown.text = drop1.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text;
            yield return new WaitForSeconds((float)1);
            drive = true;
            CanvasActualCountdownIsOn.SetActive(false);
            move_forward.color = new Color32(255, 128, 0, 255);
            yield return new WaitForSeconds((float)3);
            move_forward.color = new Color32(150, 20, 45, 45);
            winCanvas.SetActive(true);
        }
    }
}
