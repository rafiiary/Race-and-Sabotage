using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlyActiveWhenCarIs : MonoBehaviour
{
    public GameObject car;
    public GameObject codeExecution;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    // Start is called before the first frame update
    void Start()
    {
        codeExecution.SetActive(false);
        one.SetActive(false);
        two.SetActive(false);
        three.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (car.active == true)
        {
            codeExecution.SetActive(true);
            one.SetActive(true);
            two.SetActive(true);
            three.SetActive(true);
        }
    }
}
