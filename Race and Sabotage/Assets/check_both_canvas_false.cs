using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_both_canvas_false : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject car;
    public GameObject countdown;
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
        Debug.Log("both canvas are not active");
        if (other.tag == "Dreamcar01")
        {
            car.SetActive(true);
            countdown.SetActive(true);
        }
    }
}
