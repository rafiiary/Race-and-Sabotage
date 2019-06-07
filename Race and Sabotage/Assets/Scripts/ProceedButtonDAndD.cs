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
    private CarAIControl aicontrol;
    private CarAudio WaypointCarAudio;
    public Camera camera;
    private bool StartTheGame = false;

    // Start is called before the first frame update
    void Start()
    {
        WaypointCarController = WaypointCar.gameObject.GetComponent<CarController>();
        WaypointCarAudio = WaypointCar.gameObject.GetComponent<CarAudio>();
        aicontrol = WaypointCar.gameObject.GetComponent<CarAIControl>();
        StarterCanvas.gameObject.SetActive(true);
        WaypointCarController.m_Topspeed = 80;
        camera.gameObject.transform.SetParent(StarterCanvas.transform);
        //Somehow make WaypointCarAudio inaudible
        WaypointCar.gameObject.SetActive(false);
        ProceedButton.onClick.AddListener(EnableGame);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void EnableGame()
    {
        if (DropZone.firstbox && DropZone.secondbox && DropZone.thirdbox)
        {
            StarterCanvas.gameObject.SetActive(false);
            WaypointCar.gameObject.SetActive(true);
            // Somehow make WaypointCarAudio enabled.
            WaypointCarController.m_Topspeed = 80;
            camera.gameObject.transform.SetParent(WaypointCar.transform);
        }
        else
        {
            // BROADCAST TEMPORARY MESSAGE THAT THE ANSWER WRONG
        }
    }
}
