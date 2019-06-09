using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InstructionController : MonoBehaviour
{
    public GameObject canvas;
    public GameObject car;
    public TextMeshProUGUI instructions;
    public TextMeshProUGUI intro;
    bool accelerate, brake, steer;
    private void Start()
    {
        accelerate = true;
        brake = true;
        steer = true;

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up") && accelerate)
        {
            accelerate = false;
            Debug.Log("Up arrow pressed");
            canvas.active = false;
            intro.text = "";
            instructions.text = "Press the Left and Right Arrow Keys to steer Left and Right.";
        }
        if(car.GetComponent<Rigidbody>().position.x > 700 && steer)
        {
            //Pause the moving car
            canvas.active = true;
            if (Input.GetKey("left") || Input.GetKey("right"))
            {
                steer = false;
                canvas.active = false;
            }
        }
    }
}
