using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeExecutionActive : MonoBehaviour
{
    public GameObject codeExecution;
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (car.active == false)
        {
            codeExecution.SetActive(false);
        }
        else
        {
            codeExecution.SetActive(true);
        }

    }
    public void MakeActive()
    {
        codeExecution.SetActive(true);
    }
}
