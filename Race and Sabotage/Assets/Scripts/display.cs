using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class display : MonoBehaviour
{
    public GameObject canvas;
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
        MoneyCounter.UserMoney += 40;
        canvas.SetActive(true);
    }
}
