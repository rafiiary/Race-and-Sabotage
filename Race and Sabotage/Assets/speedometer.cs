using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedometer : MonoBehaviour
{
    public GameObject car;
    private UnityStandardAssets.Vehicles.Car.CarController controller;
    private string speed_type;
    private float speed;
    private float m_Topspeed;
    private float angle;
    static speedometer thisSpeedo;
    // Start is called before the first frame update
    void Start()
    {
        controller = car.transform.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>();
        thisSpeedo = this;
    }

    // Update is called once per frame
    void Update()
    {
        speed = UnityStandardAssets.Vehicles.Car.CarController.record_speed;
        m_Topspeed = controller.m_Topspeed;
        print(speed / m_Topspeed);
        angle = speed / m_Topspeed;
        if (angle>1)
        {
            angle = 1;
        }
        else if (angle < 0)
        {
            angle = 0;
        }
        thisSpeedo.transform.eulerAngles = new Vector3(0, 0, Mathf.Lerp(225, -41, angle));
    }
}
