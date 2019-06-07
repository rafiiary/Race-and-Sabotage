using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Vehicles.Car;

public class ProceedButtonDAndD : MonoBehaviour
{
    public Button ProceedButton;
    public Canvas StarterCanvas;
    public GameObject WaypointCar;
    private CarController WaypointCarController;
    private CarAudio WaypointCarAudio;

    // Start is called before the first frame update
    void Start()
    {
        WaypointCarController = WaypointCar.gameObject.GetComponent<CarController>();
        WaypointCarAudio = WaypointCar.gameObject.GetComponent<CarAudio>();
        StarterCanvas.gameObject.SetActive(true);
        WaypointCarController.m_Topspeed = 0;
        //Somehow make WaypointCarAudio inaudible
        ProceedButton.onClick.AddListener(EnableGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EnableGame()
    {
        StarterCanvas.gameObject.SetActive(false);
        // Somehow make WaypointCarAudio enabled.
        WaypointCarController.m_Topspeed = 80;
    }
}
