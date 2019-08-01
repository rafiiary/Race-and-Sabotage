using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class newProceed : MonoBehaviour
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
    public static bool otherscript = false;
    public static int NumberofWrongGuesses = 0;
    public GameObject destinations;

    // Start is called before the first frame update
    void Start()
    {
        otherscript = false;
        NumberofWrongGuesses = 0;
        WaypointCarController = WaypointCar.gameObject.GetComponent<CarController>();
        WaypointCarAudio = WaypointCar.gameObject.GetComponent<CarAudio>();
        aicontrol = WaypointCar.gameObject.GetComponent<CarAIControl>();
        StarterCanvas.gameObject.SetActive(true);
        WaypointCarController.m_Topspeed = 80;
        camera.gameObject.transform.SetParent(StarterCanvas.transform);
        //Somehow make WaypointCarAudio inaudible
        WaypointCar.gameObject.SetActive(false);
        //ProceedButton.onClick.AddListener(EnableGame);
        Incorrect.gameObject.SetActive(false);
        CodeExecPanel.gameObject.SetActive(false);
        soundPlayed = false;
        PauseCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown > 0)
        {
            Incorrect.gameObject.SetActive(true);
            countdown--;
        }
        else
        {
            soundPlayed = !soundPlayed;
            Incorrect.gameObject.SetActive(false);
        }
    }

    public void EnableGame()
    {
        GetCorrect();
        if ((DOneAnswerKey.allSolved) || otherscript)
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
            NumberofWrongGuesses += 1;
        }
    }
    public void GetCorrect()
    {
        int i = 0;
        for (int j = 0; j < 12; j++)
        {
            Debug.Log("count");
            if (destinations.transform.GetChild(j).childCount > 0) {
                if(destinations.transform.GetChild(j).gameObject.tag == destinations.transform.GetChild(j).GetChild(0).gameObject.tag)
                {
                    i++;
                }
            }
        }

        if (i == 12)
        {
            newProceed.otherscript = true;
        }
    }
    IEnumerator WaitBeforeResettingDragAndDrop()
    {
        yield return new WaitForSeconds((float)1);
        otherscript = false;
    }
}
