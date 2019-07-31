using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TriggerTooFast : MonoBehaviour
{
    public GameObject loseCanvas;
    public TextMeshProUGUI feedback;
    public string feedback_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        ////debug.log("it has entered the trigger");
        StartCoroutine(Example3());
    }
    IEnumerator Example3()
    {
        yield return new WaitForSeconds((float)1.5);
        ////debug.log("it has entered the trigger");
        if (UnityStandardAssets.Vehicles.Car.moveLevel1scene2.FORWARD > 140)
        {
            //feedback.GetComponent<TMPro.TextMeshProUGUI>().text = "Try a slower speed and a bigger angle";
            feedback.text = "Try going slower and turning faster.";
        }
        if (feedback_text != "")
        {
            feedback.text = feedback_text;
        }
        loseCanvas.SetActive(true);
        Time.timeScale = 0;
    }
}
