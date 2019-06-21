using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowActiveProblems : MonoBehaviour
{
    public GameObject arrows;
    public GameObject timer;
    public GameObject code;
    // Start is called before the first frame update
    void Start()
    {
        arrows.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (code.active == false)
        {
            arrows.SetActive(false);
        }
        else
        {
            arrows.SetActive(true);
        }
    }
}
