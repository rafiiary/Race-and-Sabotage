using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyPickup : MonoBehaviour
{
    public GameObject Car;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ENTERED HERE");
        Debug.Log("MONEY COLLECTED");
        MoneyCounter.UserMoney += 1;
        Debug.Log("USER MONEY NOW IS " + MoneyCounter.UserMoney.ToString());
        Destroy(gameObject);
        Debug.Log("GAMEOBJECT DESTROYED");
        //if (other.gameObject.tag == Car.gameObject.tag)
        //{
        //    Debug.Log("MONEY COLLECTED");
        //    MoneyCounter.UserMoney += 1;
        //    Debug.Log("USER MONEY NOW IS " + MoneyCounter.UserMoney.ToString());
        //    Destroy(gameObject);
        //    Debug.Log("GAMEOBJECT DESTROYED");
        //}
    }
}
