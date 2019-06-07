using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragDropEndRaceScript : MonoBehaviour
{
    public GameObject car;
    public Canvas WinCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("this is working");
        WinCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("PLS WORK THANK");
        if (collision.gameObject.tag == "car1")
        {
            car.gameObject.SetActive(false);
            WinCanvas.gameObject.SetActive(true);
        }
    }
    
}
