using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class NextButton : MonoBehaviour
{
    public GameObject next;
    public GameObject next2;
    public GameObject explainElseif;
    public GameObject explainElseif2;

    public static int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ContinueOntoNext()
    {
        count += 1;
        ShowPanel.paused = false;
        if (count == 1)
        {
            move.letCodeExecution = false;
            explainElseif.SetActive(false);
            next.SetActive(false);
            next2.SetActive(false);
        }
        else
        {
            move.letCodeExecution = false;
            explainElseif2.SetActive(false);
            next2.SetActive(false);
            next.SetActive(false);
        }
        
        move.letCodeExecution2 = false;
        move2.proceed = true;
        Time.timeScale = 1;
    }
}
