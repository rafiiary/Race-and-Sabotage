using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winning_left_over : MonoBehaviour
{
    [SerializeField] Text money_left;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        money_left.text = "You have $" + (Money_counter.money + Money_counter.bet_amount * 2).ToString() + " after betting $" + Money_counter.bet_amount.ToString() + ".";
    }
}
