using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCanvasTimer : MonoBehaviour
{
    public static int TimerInt = -1;
    public Canvas EndCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerInt > 0)
        {
            TimerInt--;
        }
        if (TimerInt == 0)
        {
            EndCanvas.gameObject.SetActive(true);
        } else
        {
            EndCanvas.gameObject.SetActive(false);
        }
        Debug.Log("timer int is " + TimerInt.ToString());
    }
}
