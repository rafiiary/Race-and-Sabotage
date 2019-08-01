using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DigitalSpeedometer : MonoBehaviour
{

    public GameObject digitalSpeed;
    public GameObject Car;
    public GameObject input_destination;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        digitalSpeed.GetComponent<TextMeshProUGUI>().text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        speed = Mathf.Round(UnityStandardAssets.Vehicles.Car.CarController.record_speed);
        if (input_destination.transform.childCount > 0)
        {
            if (speed > Int32.Parse(input_destination.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text));
            {
                speed = Mathf.Floor(speed);
            }
        }
        digitalSpeed.GetComponent<TextMeshProUGUI>().text = speed.ToString() + " km/h";
    }
}
