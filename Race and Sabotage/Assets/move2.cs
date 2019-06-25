using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using TMPro;
using System.Collections;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class move2 : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        public GameObject drop1;
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

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
            watchCodeExecution.SetActive(false);
            if_statement.color = new Color32(150, 20, 45, 45);
            if_content.color = new Color32(150, 20, 45, 45);
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
            if (drop1.transform.childCount > 0)
            {
                Debug.Log(timeDone.ToString() + "timeDone");
                Debug.Log(timeDone2.ToString() + "timeDone2");
                if_statement.text = drop1.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text + "(notFinishedDonut){";
                dragAndDropCanvas.SetActive(false);
                watchCodeExecution.SetActive(true);
                Debug.Log("it got here");
                if (drop1.transform.GetChild(0).tag == "right")
                {
                    Debug.Log("right");
                    m_Car.Move(20, 2, 0, 0);
                }
                else if (drop1.transform.GetChild(0).tag != "right" & !timeDone)
                {
                    m_Car.Move(10, 10, 0, 0);
                    StartCoroutine(Example((float)2));
                    if_statement.color = new Color32(255, 128, 0, 255);
                    StartCoroutine(if_statement_pause((float)1));
                    StartCoroutine(turnOffEverything((float)2.5));
                }
                if (timeDone2)
                {
                    Debug.Log("turning the if content turn");
                    if_statement.color = new Color32(150, 20, 45, 45);
                    if_content.color = new Color32(255, 128, 0, 255);
                }
                if (timeDone)
                {
                    //makes the car stop if the player puts the "if" in the drag and drop
                    Debug.Log("left");
                    m_Car.Move(0, 0, 1000, 1000);
                    if_statement.color = new Color32(150, 20, 45, 45);
                    //if_content.color = new Color32(150, 20, 45, 45);
                }
                if(timeDone3)
                {
                    if_statement.color = new Color32(150, 20, 45, 45);
                    if_content.color = new Color32(150, 20, 45, 45);
                }
            }

#else
            m_Car.Move(h, v, v, 0f);

#endif
        }
        IEnumerator Example(float time)
        {
            timeDone = false;
            yield return new WaitForSeconds((float)time);
            timeDone = true;
            if_statement.color = new Color32(150, 20, 45, 45);
            //if_content.color = new Color32(150, 20, 45, 45);
            entered = true;
        }
        IEnumerator if_statement_pause(float time)
        {
            Debug.Log("did it even enter the second one");
            timeDone2 = false;
            yield return new WaitForSeconds((float)time);
            timeDone2 = true;
        }
        IEnumerator turnOffEverything(float time)
        {
            Debug.Log("did it even enter the second one");
            timeDone3 = false;
            yield return new WaitForSeconds((float)time);
            timeDone3 = true;
        }

    }
}