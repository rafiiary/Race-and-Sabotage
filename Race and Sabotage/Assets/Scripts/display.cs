using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class display : MonoBehaviour
{
    public GameObject canvas;
    public GameObject canvasWithRocket;
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
        MoneyCounter.UserMoney += 10;
        canvas.SetActive(true);
        canvasWithRocket.SetActive(true);
    }
}
