using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartLevelMoneyDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void CheckingIfBetApplied()
    {
        if(Money_counter.HitApplied)
        {
            ////debug.log("BET MONEYYYYYYYYYYYYY " + Money_counter.bet_amount.ToString());
            MoneyCounter.UserMoney += (int)Money_counter.bet_amount;
        }
    }
}
