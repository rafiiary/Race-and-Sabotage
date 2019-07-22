using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetMoney : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //debug.log("TIMESCALE!!!!!!!!!!!!!!!!! " + Time.timeScale.ToString());
    }
    public void ResetMoney()
    {
        MoneyCounter.UserMoney = 0;
    }
}
