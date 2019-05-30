using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lost_bet_money : MonoBehaviour
{
    public GameObject total_money;
    [SerializeField] Text money_left;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        money_left.text = "You have $" + (Money_counter.money).ToString() + " left " + "after betting $" + Money_counter.bet_amount.ToString() + ".";
        return;
    }
}
