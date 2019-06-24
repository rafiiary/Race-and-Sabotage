using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDictate : MonoBehaviour
{
    public GameObject panel1, panel2, panel3;
    private int counter = 300;
    // Start is called before the first frame update
    void Start()
    {
        panel1.gameObject.SetActive(true);
        panel2.gameObject.SetActive(true);
        panel3.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        counter--;
        if (25 < counter && counter < 125)
        {
            panel2.gameObject.SetActive(false);
            panel1.gameObject.SetActive(true);
            panel3.gameObject.SetActive(true);
        }
        else if (125 < counter)
        {
            panel1.gameObject.SetActive(false);
            panel2.gameObject.SetActive(true);
            panel3.gameObject.SetActive(true);
        }
        else
        {
            panel3.gameObject.SetActive(false);
            panel2.gameObject.SetActive(true);
            panel1.gameObject.SetActive(true);
        }
    }
}
