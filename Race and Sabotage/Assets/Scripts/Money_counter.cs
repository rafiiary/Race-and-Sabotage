using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money_counter : MonoBehaviour
{
    [SerializeField] Text count;
    [SerializeField] Text bet;
    public static float money;
    public static float bet_amount;
    float bet_for_the_round = 0f;
    public GameObject apply;
    public GameObject next;
    public GameObject input;
    public GameObject camera;
    [SerializeField] Text error;
    public GameObject restart;
    // Start is called before the first frame update
    void Start()
    {
        money = MoneyCounter.UserMoney;
        bet_amount = 0;
 
        count.text = "Amount: " + "$ " + MoneyCounter.UserMoney.ToString();
        bet.text = "Bet: " + "$" + bet_for_the_round.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        count.text = "Amount: " + "$ " + MoneyCounter.UserMoney.ToString();
        bet.text = "Bet: " + "$" + bet_for_the_round.ToString();
        if (MoneyCounter.UserMoney < 250)
        {
            print("yes");
            error.text = "You need at least $250 to start betting";
            Destroy(input);
            Destroy(apply);
            restart.SetActive(true);
        }
        else
        {
            error.text = "";
            restart.SetActive(false);
        }

    }
    public void text_changed(string newText)
    {
        if (!float.TryParse(newText, out bet_amount))
        {
            print("failed");
            return;
        }
        else {
            bet_amount = float.Parse(newText);
            print("bet amount" + bet_amount.ToString());
            print("bet amount type" + bet_amount.GetType().ToString());
            print("count " + count.text.ToString());
            print("bet amount type" + count.text.GetType().ToString());
            if (bet_amount > money)
            {
                bet_amount = money;
            }
            if (bet_amount < 0)
            {
                bet_amount = 0;
            }
        }
    }
    public void applied_hit()
    {
        if (money-bet_amount >=0)
        {
            money = money - bet_amount;
            bet_for_the_round += bet_amount;
            print("This is the bet" + bet_for_the_round.ToString());
            apply.active = false;
            next.active = true;
            input.active = false;
        }
    }
    public float money_return()
    {
        return (money - bet_amount);
    }
    public float bet_return()
    {
        return (bet_amount);
    }
}
