using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class NextButton : MonoBehaviour
{
    public GameObject next;
    public GameObject explainElseif;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ContinueOntoNext()
    {
        ShowPanel.paused = false;
        move.letCodeExecution = false;
        next.SetActive(false);
        explainElseif.SetActive(false);
        Time.timeScale = 1;
    }
}
