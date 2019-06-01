using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject winningCar;
    public GameObject winningCanvas;
    public GameObject FinishingLine;
    public GameObject losingCanvas;
    public Collider FinishCollider;
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
    }
    bool random;
    void Awake()
    {

        source = GetComponent<AudioSource>();

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.gameObject.CompareTag("Dreamcar01"))
        {
            Debug.Log("Game Won!");
            gameWon = true;
            source.PlayOneShot(cheer_sound, volume);
            winningCanvas.gameObject.SetActive(true);
        }
        else
        {
            Debug.Log("Game lost!");
            gameWon = false;
            losingCanvas.gameObject.SetActive(true);
        }
        FinishCollider.isTrigger = false;
        FinishCollider.enabled = false;

    }
}
