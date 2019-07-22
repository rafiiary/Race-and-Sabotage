using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Vehicles.Car;

public class FinishLine : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject winningCar;
    public GameObject winningCanvas;
    public GameObject FinishingLine;
    public GameObject losingCanvas;
    public Collider FinishCollider;
    private CarController winningCarController;
    private CarAIControl AIcontroller;
    bool gameWon;

    // Static variables
    public static bool game_over;

    float volume = 1.0f;
    AudioSource source;
    public AudioClip cheer_sound;
    private void Start()
    {
        winningCanvas.gameObject.SetActive(false);
        losingCanvas.gameObject.SetActive(false);
        FinishCollider = FinishingLine.GetComponent<BoxCollider>();
        gameWon = false;
        game_over = false;
        winningCarController = winningCar.gameObject.GetComponent<CarController>();
        AIcontroller = winningCar.gameObject.GetComponent<CarAIControl>();
    }
    bool random;
    void Awake()
    {

        source = GetComponent<AudioSource>();

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Dreamcar01")
        {
            gameWon = true;
            source.PlayOneShot(cheer_sound, volume);
            winningCanvas.gameObject.SetActive(true);
            mainCam.gameObject.transform.SetParent(winningCanvas.transform);
            MoneyCounter.UserMoney += 50;

        }
        else
        {
            gameWon = false;
            losingCanvas.gameObject.SetActive(true);
            mainCam.gameObject.transform.SetParent(losingCanvas.transform);
            MoneyCounter.UserMoney += 30;

        }
        FinishCollider.isTrigger = false;
        FinishCollider.enabled = false;
        winningCarController.m_Topspeed = 0;
        winningCar.gameObject.SetActive(false);

    }
}
