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
    public GameObject GoStraightPanel, StartCodePanel;
    public GameObject CodeExecPanel;
    public Canvas PauseCanvas;
    public static int NumberOfWrongGuesses = 0;

    public static bool otherscript = false;

    // Start is called before the first frame update
    void Start()
    {
        NumberOfWrongGuesses = 0;
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
        CodeExecPanel.gameObject.SetActive(false);
        soundPlayed = false;
        PauseCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(otherscript.ToString() + "other script");
        if (countdown > 0)
        {
            Incorrect.gameObject.SetActive(true);
            camera.transform.SetParent(Incorrect.transform);
            countdown--;
        } else
        {
            soundPlayed = !soundPlayed;
            Incorrect.gameObject.SetActive(false);
            camera.transform.SetParent(StarterCanvas.transform);
        }
    }

    public void EnableGame()
    {
        if (DTwoAnswerKeys.allSolved || otherscript)
        {
            CodeExecPanel.gameObject.SetActive(true);
            StarterCanvas.gameObject.SetActive(false);
            WaypointCar.gameObject.SetActive(true);
            // Somehow make WaypointCarAudio enabled.
            WaypointCarController.m_Topspeed = 80;
            camera.gameObject.transform.SetParent(WaypointCar.transform);
            GoStraightPanel.gameObject.SetActive(false);
            StartCodePanel.gameObject.SetActive(false);
            PauseCanvas.gameObject.SetActive(true);
            StartCoroutine(WaitBeforeResettingDragAndDrop());
        }
        else
        {
            soundPlayed = !soundPlayed;
            speaker.PlayOneShot(wrongChoice);
            countdown = 40;
            NumberOfWrongGuesses += 1;
        }
    }
    IEnumerator WaitBeforeResettingDragAndDrop()
    {
        yield return new WaitForSeconds((float)1);
        otherscript = false;
    }
}
