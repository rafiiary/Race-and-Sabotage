using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using TMPro;
using System.Collections;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class moveLevel1scene2 : MonoBehaviour
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
        public static float TURN = 0;
        public static float FORWARD = 0;
        private bool if_statement_done;

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
            //debug.log("MOVELEVEL1SCENE2");
            Time.timeScale = 1;
        }

        private void FixedUpdate()
        {
            //debug.log(FORWARD);
            //debug.log(TURN);
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            ////print("H" + (h * 10000).ToString());
            float v = CrossPlatformInputManager.GetAxis("Vertical");
            ////print("V" + v.ToString());
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            //m_Car.Move(5, 2, v, handbrake)
            //debug.log(FORWARD);
            m_Car.Move(TURN, FORWARD, 0, 0);
            if (drop1.transform.childCount > 0)
            {
                //debug.log("drop1transform");
                FORWARD = float.Parse(drop1.transform.GetChild(0).transform.GetChild(1).GetComponent<TMP_Text>().text);
                Destroy(barrier);
                dragAndDropCanvas.SetActive(false);
                m_Car.Move(TURN, FORWARD, 0, 0);
                m_Car.m_Topspeed = FORWARD;
            }
            //debug.log("before entered the second drag and drop canvas");
            if (drop2.transform.childCount>0)
            {
                //debug.log("entered the second drag and drop canvas");
                TURN = (float.Parse(drop2.transform.GetChild(0).transform.GetChild(1).GetComponent<TMP_Text>().text))/100;
                dragAndDropCanvas2.SetActive(false);
                m_Car.Move(TURN, FORWARD, 0, 0);
                //debug.log("MOVELEVEL1SCENE2");
                Time.timeScale = 1;
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
