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
        public GameObject explanationCanvas;
        public GameObject barrier;
        private bool secondCanvasDone;
        public static bool correct_input = false;
        bool right = false;
        private bool entered = false;
        private bool timeDone = true;
        private bool timeDone2 = false;
        private bool timeDone3 = false;
        private bool timeDone4 = false;
        public GameObject loseCanvas;
        public TextMeshProUGUI loseCanvasText;
        public TextMeshProUGUI feedback;
        public GameObject feedback_object;
        public GameObject winCanvas;
        public TextMeshProUGUI speedIs140;
        public TextMeshProUGUI firstcanvas;
        public TextMeshProUGUI secondCavnas;
        public TextMeshProUGUI ifOrWhile;
        public TextMeshProUGUI loopContent;
        public GameObject codeExecution;
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
        private int count = 70;
        private string colortext;

        private void Awake()
        {
            speedIs140.color = new Color32(150, 20, 45, 45);
            firstcanvas.color = new Color32(150, 20, 45, 45);
            secondCavnas.color = new Color32(150, 20, 45, 45);
            ifOrWhile.color = new Color32(150, 20, 45, 45);
            loopContent.color = new Color32(150, 20, 45, 45);
            m_Car = GetComponent<CarController>();
            m_Rigidbody = GetComponent<Rigidbody>();
            TURN = 0;
            FORWARD = 0;

        }

        private void Update()
        {

            if (drop22.transform.childCount > 0 & dragAndDropCanvas2.active == false)
            {
                if (!timeDone4)
                {
                    StartCoroutine(secondTurn(1));
                }
                //THIS WILL GET IT TO DO THE WHILE LOOP
                if (drop22.transform.GetChild(0).tag == "while" & timeDone & timeDone3)
                {
                    StartCoroutine(correctIf((float)0.8));
                }
                //THIS WILL GET IT TO DO THE IF LOOP
                else if (drop22.transform.GetChild(0).tag == "if" & !timeDone2 & timeDone3)
                {
                    StartCoroutine(incorrectIF((float)0.8));
                    loseCanvasText.text = "If statements can only loop once.";
                }
            }
            else if(drop22.transform.childCount > 0)
            {
                if (drop22.transform.GetChild(0).tag == "while")
                {
                    colortext = "<color=#ff00ffff>";
                }
                else if(drop22.transform.GetChild(0).tag == "if")
                {
                    colortext = "<color=#58A251>";
                }
            }
            if ((Time.timeScale == 0 || dragAndDropCanvas.active == true|| dragAndDropCanvas2.active == true|| winCanvas.active == true || loseCanvas.active == true || explanationCanvas.active == true))
            {
                codeExecution.SetActive(false);
            }
            else if (drop1.transform.childCount > 0)
            {
                codeExecution.SetActive(true);
            }
            RaycastHit objectHit;
            Vector3 fwd = raycastObject.transform.TransformDirection(Vector3.forward);
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            ////print("H" + (h * 10000).ToString());
            float v = CrossPlatformInputManager.GetAxis("Vertical");
            ////print("V" + v.ToString());
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            //m_Car.Move(5, 2, v, handbrake)
            ////debug.log(FORWARD);
            if (stop)
            {
                Time.timeScale = 0;
                ShowPanel.paused = true;



                AudioListener.pause = true;



            }
            if (Physics.Raycast(raycastObject.transform.position, fwd, out objectHit, 2) & first_done & !second_done)
            {
                dragAndDropCanvas2.SetActive(true);
                Time.timeScale = 0;
                ShowPanel.paused = true;



                AudioListener.pause = true;



                loseCanvas.SetActive(true);
                feedback.text = "You almost crashed! Try a different combination.";
            }
            if (Time.timeScale != 0)
            {
                m_Car.Move(TURN, FORWARD, FOOTBRAKES, FOOTBRAKES);
            }
            //THIS IS FOR THE SECOND CANVAS FIRST DROP
            //THIS IS FOR THE FIRST CANVAS AND THE ONLY DROP DESTINATION
            if (drop11.transform.childCount > 0 & drop22.transform.childCount > 0 & drop33.transform.childCount > 0)
            {
                if ((drop22.transform.GetChild(0).tag == "left" || drop22.transform.GetChild(0).tag == "right" || drop22.transform.GetChild(0).tag == "forward" || drop11.transform.GetChild(0).tag == "if" || drop11.transform.GetChild(0).tag == "while" || drop33.transform.GetChild(0).tag == "if" || drop33.transform.GetChild(0).tag == "while"))
                {
                    //loseCanvas.SetActive(true);
                    feedback.text = "Error: this combination doesn't make sense";
                    if (!syntax)
                    {
                        feedback_object.SetActive(true);
                        if (count != 0)
                        {
                            count--;
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
                    ShowPanel.paused = true;



                    AudioListener.pause = true;



                    return;
                }
                else
                {
                    ShowPanel.paused = false;
                }
                second_done = true;
                //Time.timeScale = 1;
                dragAndDropCanvas2.SetActive(false);
                secondCavnas.text = "<color=black>" + drop11.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text;
                string[] subStrings = drop22.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text.Split('>');
                ifOrWhile.text = colortext+subStrings[1] + "(RaceNotDone){";
                loopContent.text = "          " +colortext + drop33.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text + "}"+"</color>";
                StartCoroutine(Example3());
                StartCoroutine(TakingTooLong());
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
                ShowPanel.paused = true;


                AudioListener.pause = true;



            }
            else
            {
                ShowPanel.paused = false;
            }
            if (drop1.transform.childCount > 0 & !first_done)
            {
                StartCoroutine(firstcanvasstart());
                firstcanvas.text = "<color=black>"+drop1.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text;
                Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
               
                if (drop1.transform.GetChild(0).tag == "forward" & !Physics.Raycast(raycastObject.transform.position, fwd, out objectHit, 10))
                {
                    TURN = 0;
                    FORWARD = 10;
                    first_done = true;
                }
                if (drop1.transform.GetChild(0).tag == "left")
                {
                    TURN = (float)-6;
                    FORWARD = 10;
                    first_done = true;
                }
                if (drop1.transform.GetChild(0).tag == "right")
                {
                    TURN = (float)6;
                    FORWARD = 10;
                    first_done = true;
                }
                Destroy(barrier);
                dragAndDropCanvas.SetActive(false);
                //m_Car.Move(TURN, FORWARD, 0, 0);
                m_Car.m_Topspeed = 100;
            }
            if (drop11.transform.childCount > 0 & !secondCanvasDone)
            {
                if (drop11.transform.GetChild(0).tag == "forward")
                {
                    TURN = 0;
                    //FORWARD = 10;
                    direction = "forward";
                    first_done = true;
                    secondCanvasDone = true;
                }
                else if (drop11.transform.GetChild(0).tag == "left")
                {
                    TURN = (float)-6;
                    //FORWARD = 10;
                    first_done = true;
                    secondCanvasDone = true;
                }
                else if (drop11.transform.GetChild(0).tag == "right")
                {
                    TURN = (float)6;
                    // FORWARD = 10;
                    first_done = true;
                    secondCanvasDone = true;
                }
                //if (drop22.transform.GetChild(0).tag == "if")
                //{
                //    StartCoroutine(UsingIf());
                //}
            }
            IEnumerator Example3()
            {
                yield return new WaitForSeconds((float)0.93);
                if (drop33.transform.GetChild(0).tag == "forward")
                {
                    TURN = 0;
                }
                else if (drop33.transform.GetChild(0).tag == "right")
                {
                    TURN = 6;
                }
                else if (drop33.transform.GetChild(0).tag == "left")
                {
                    TURN = -6;
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
                //stop = true;
                FOOTBRAKES = 10;
                yield return new WaitForSeconds((float)0.5);
                loseCanvas.SetActive(true);
                feedback.text = "If statements only loop once!";
            }
            IEnumerator SyntaxError()
            {
                yield return new WaitForSeconds((float)0.0);
            }
            IEnumerator TakingTooLong()
            {
                yield return new WaitForSeconds((float)9);
                if (winCanvas.active == false)
                {
                    loseCanvas.SetActive(true);
                }
                if (loseCanvasText.text.Length <= 0)
                {
                    loseCanvasText.text = "You took too long!";
                }
            }
            IEnumerator correctIf(float time)
            {
                timeDone = false;
                OnlyLightUPIf();
                yield return new WaitForSeconds((float)time);
                StopCoroutine("correctIf");
                OnlyLightUPIfcontent();
                yield return new WaitForSeconds((float)time);
                timeDone = true;
            }
            IEnumerator incorrectIF(float time)
            {
                timeDone2 = true;
                OnlyLightUPIf();
                yield return new WaitForSeconds((float)time);
                OnlyLightUPIfcontent();
                yield return new WaitForSeconds((float)1.5);
                AllDark();
            }
            IEnumerator secondTurn(float time)
            {
                timeDone4 = true;
                yield return new WaitForSeconds((float)0.1);
                secondCavnas.color = new Color32(255, 128, 0, 255);
                yield return new WaitForSeconds((float)1);
                secondCavnas.color = new Color32(150, 20, 45, 45);
                timeDone3 = true;
            }
            IEnumerator firstcanvasstart()
            {
                speedIs140.color = new Color32(255, 128, 0, 255);
                yield return new WaitForSeconds((float)0.7);
                speedIs140.color = new Color32(150, 20, 45, 45);
                firstcanvas.color = new Color32(255, 128, 0, 255);
                yield return new WaitForSeconds((float)0.7);
                firstcanvas.color = new Color32(150, 20, 45, 45);
            }
            void OnlyLightUPIf()
            {
                ifOrWhile.color = new Color32(255, 128, 0, 255);
                loopContent.color = new Color32(150, 20, 45, 45);
            }
            void OnlyLightUPIfcontent()
            {
                loopContent.color = new Color32(255, 128, 0, 255);
                ifOrWhile.color = new Color32(150, 20, 45, 45);
            }
            void AllDark()
            {
                ifOrWhile.color = new Color32(150, 20, 45, 45);
                loopContent.color = new Color32(150, 20, 45, 45);
            }
#else
            m_Car.Move(h, v, v, 0f);

#endif
        }

    }
}
