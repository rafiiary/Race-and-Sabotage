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
        public bool left = false;
        bool right = false;
        public GameObject countdown;
        public TextMeshProUGUI if_statement;
        public TextMeshProUGUI if_content;
        public TextMeshProUGUI if_else;
        public TextMeshProUGUI if_else_content;
        public GameObject watchCodeExecution;
        private bool entered;
        private bool timeDone;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
            //if_statement = if_statement.GetComponent<TextMeshProUGUI>();
            if_statement.text = "if (left_arrow_key_pressed() {";
            //if_else = if_else.GetComponent<TextMeshProUGUI>();
            if_else.text = "else if (right_arrow_key_pressed()) {";
            watchCodeExecution.SetActive(false);
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
            if (drop1.transform.childCount > 0 && drop2.transform.childCount > 0)
            {
                dragAndDropCanvas.SetActive(false);
                if (drop1.transform.GetChild(0).tag == "left")
                {
                    m_Car.Move(h, v, v, handbrake);
                    left = true;
                }
                else if (drop1.transform.GetChild(0).tag == "right")
                {
                    m_Car.Move(-h, v, v, handbrake);
                }
                else
                {
                    m_Car.Move(0, 0, 0, 0);
                }
                //if_content = drop1.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                if_content.text = drop1.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text ;
                //if_else = if_else.GetComponent<TextMeshProUGUI>();
                //if_else_content = drop2.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                if_else_content.text = drop2.transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text;

            }
            if (countdown.active == false && dragAndDropCanvas.active == false)
            {
                watchCodeExecution.SetActive(true);
            }
            if (h>0 && watchCodeExecution.active == true)
            {
                // to make it dull use (150, 20, 45, 45), for it to be dark, use (255, 128, 0, 255)
                if_else.color = new Color32(150, 20, 45, 45);
                if_else_content.color = new Color32(150, 20, 45, 45);
                if_statement.color = new Color32(255, 128, 0, 255);
                if_content.color = new Color32(255, 128, 0, 255);
                entered = false;
            }
            else if(h<0 && watchCodeExecution.active == true)
            {
                //Debug.Log("entered" + entered.ToString());
                if (!entered)
                {
                    Debug.Log("entered");
                    if_statement.color = new Color32(255, 128, 0, 255);
                    StartCoroutine(Example());
                    print("1");
                    entered = true;
                }
                if (timeDone)
                {
                    if_statement.color = new Color32(150, 20, 45, 45);
                    if_content.color = new Color32(150, 20, 45, 45);
                    if_else.color = new Color32(255, 128, 0, 255);
                    if_else_content.color = new Color32(255, 128, 0, 255);
                }
            }
            else
            {
                if_content.color = new Color32(150, 20, 45, 45);
                if_statement.color = new Color32(150, 20, 45, 45);
                if_else.color = new Color32(150, 20, 45, 45);
                if_else_content.color = new Color32(150, 20, 45, 45);
                entered = false;
            }
            Debug.Log(if_statement.color);
            IEnumerator Example()
            {
                timeDone = false;
                yield return new WaitForSeconds((float)0.2);
                timeDone = true;
            }
#else
            m_Car.Move(h, v, v, 0f);

#endif
        }
    }
}
