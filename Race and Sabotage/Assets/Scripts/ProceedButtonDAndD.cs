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
    public Image Incorrect;
    private CarAudio WaypointCarAudio;
    public Camera camera;
    private bool StartTheGame = false;
    private int countdown = 0;
    bool soundPlayed;
    public AudioSource speaker;
    public AudioClip wrongChoice;

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
        Incorrect.gameObject.SetActive(false);
        soundPlayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown > 0)
        {
            Incorrect.gameObject.SetActive(true);
            countdown--;
        } else
        {
            soundPlayed = !soundPlayed;
            Incorrect.gameObject.SetActive(false);
        }
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
            soundPlayed = !soundPlayed;
            speaker.PlayOneShot(wrongChoice);
            countdown = 40;
        }
    }
}
