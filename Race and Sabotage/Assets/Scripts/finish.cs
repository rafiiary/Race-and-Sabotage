using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    public GameObject win_canvas;
    public GameObject car;
    public GameObject lose_canvas;
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Dreamcar01")
        {
            if (lose_canvas.active == false)
            {
                win_canvas.SetActive(true);
                camera.transform.parent = null;
                car.SetActive(false);
                MoneyCounter.UserMoney += 50;
            }

        }
        else
        {
            if (win_canvas.active == false)
            {
                lose_canvas.SetActive(true);
            }
        }
    }
}
