using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class triggerStaticVariable : MonoBehaviour
{
    public bool turning_left;
    public bool turning_right;
    private bool inside_trigger;
    public TextMeshProUGUI if_statement;
    public TextMeshProUGUI if_content;
    public TextMeshProUGUI if_else;
    public TextMeshProUGUI if_else_content;
    public GameObject self;
    private bool timeDone;
    private bool entered = true;
    public GameObject next;
    // Start is called before the first frame update
    void Start()
    {
        turning_left = false;
        turning_right = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (turning_right)
        {
            if_statement.transform.GetComponent<TMP_Text>().color = new Color32(255, 128, 0, 255);
            if_content.transform.GetComponent<TMP_Text>().color = new Color32(255, 128, 0, 255);
        }
        else if (turning_left)
        {
            if_statement.transform.GetComponent<TMP_Text>().color = new Color32(255, 128, 0, 255);
            StartCoroutine(Example());
            if (timeDone == true)
            {
                if_statement.transform.GetComponent<TMP_Text>().color = new Color32(150, 20, 45, 45);
                if_else.transform.GetComponent<TMP_Text>().color = new Color32(255, 128, 0, 255);
                if_else_content.transform.GetComponent<TMP_Text>().color = new Color32(255, 128, 0, 255);
                entered = false;
            }

        }
        else
        {
            if_statement.transform.GetComponent<TMP_Text>().color = new Color32(150, 20, 45, 45);
            if_content.transform.GetComponent<TMP_Text>().color = new Color32(150, 20, 45, 45);
            if_else.transform.GetComponent<TMP_Text>().color = new Color32(150, 20, 45, 45);
            if_else_content.transform.GetComponent<TMP_Text>().color = new Color32(150, 20, 45, 45);
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Dreamcar01")
        {
            if (self.tag == "left")
            {
                turning_left = true;
            }
            else if (self.tag == "right")
            {
                turning_right = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Dreamcar01")
        {
            turning_left = false;
            turning_right = false;
            Destroy(self);
            if (next != null)
            {
                next.SetActive(true);
            }
        }
    }
    IEnumerator Example()
    {
        if (entered)
        {
            print("ienumerator");
            yield return new WaitForSeconds((float)0.2);
            timeDone = true;
            print("done delay");
        }
    }
}
