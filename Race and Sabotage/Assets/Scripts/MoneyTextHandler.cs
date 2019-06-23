using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyTextHandler : MonoBehaviour
{
    public Text MoneyText;
    private static float previousMoney;
    private bool notEntered = true;
    private bool enumerate = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(previousMoney);
        Debug.Log(MoneyCounter.UserMoney);
        //MoneyText.text = "YOUR MONEY: " + MoneyCounter.UserMoney.ToString();
        if (previousMoney != MoneyCounter.UserMoney)
        {
            previousMoney = previousMoney + 1;
            Debug.Log(previousMoney);
        }
        MoneyText.text = "YOUR MONEY: " + previousMoney;
    }
    //void IncreaseText()
    //{
    //    notEntered = false;
    //    Debug.Log("INCREASEDTEXT");
    //    while (previousMoney != MoneyCounter.UserMoney)
    //    {
    //        if (enumerate)
    //        {
    //            previousMoney = previousMoney + 1;
    //        }
    //        StartCoroutine(wait((float)0.1));
    //    }
    //}
    //private IEnumerator wait(float waitTime)
    //{
    //    enumerate = false;
    //    yield return new WaitForSeconds(waitTime);
    //    enumerate = true;
    //}
}
