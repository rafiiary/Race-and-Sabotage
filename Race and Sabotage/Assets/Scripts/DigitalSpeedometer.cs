using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DigitalSpeedometer : MonoBehaviour
{

    public GameObject digitalSpeed;
    public GameObject Car;
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
        digitalSpeed.GetComponent<TextMeshProUGUI>().text = speed.ToString() + " km/h";
    }
}
