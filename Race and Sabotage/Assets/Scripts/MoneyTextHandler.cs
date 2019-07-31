using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyTextHandler : MonoBehaviour
{
/*    public Text MoneyText;
    private static float previousMoney;
    private bool notEntered = true;
    private bool enumerate = true;
    public GameObject rocket;
    private bool increaseDone = false;
    private bool decreaseStart = false;
    // Start is called before the first frame update
    void Start()
    {
        rocket.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //MoneyText.text = "YOUR MONEY: " + MoneyCounter.UserMoney.ToString();
        if (previousMoney != MoneyCounter.UserMoney)
        {
            previousMoney += 1;
            //////debug.log(previousMoney);
        }
        else
        {
            previousMoney = MoneyCounter.UserMoney;
            MoneyText.text = ""; //+ MoneyCounter.UserMoney;
        }
        if (previousMoney == MoneyCounter.UserMoney)
        {
            //increase the font size
            if (MoneyText.fontSize != 31 & !increaseDone)
            {
                MoneyText.fontSize += 1;
                if (MoneyText.fontSize == 30)
                {
                    increaseDone = true;
                }
            }
            //decrease the font size
            if (MoneyText.fontSize <= 30 & increaseDone)
            {
                if (MoneyText.fontSize != 25)
                {
                    MoneyText.fontSize -= 1;
                }
            }
            rocket.SetActive(true);
        }
        MoneyText.text = "";// + previousMoney;
    }
    //void IncreaseText()
    //{
    //    notEntered = false;
    //    ////debug.log("INCREASEDTEXT");
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
    */
}
