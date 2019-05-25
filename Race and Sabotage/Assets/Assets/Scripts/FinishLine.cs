using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject winningCar;
    public GameObject winningCanvas;
    bool gameWon;

    // Static variables
    public static bool game_over;

    float volume = 1.0f;
    AudioSource source;
    public AudioClip cheer_sound;
    private void Start()
    {
        winningCanvas.active = false;
        gameWon = false;
        game_over = false;
    }

    void Awake()
    {

        source = GetComponent<AudioSource>();

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Dreamcar01"))
        {
            //if (input_activity.game_won && game_over)
            if (input_activity.game_won)
            {
                Debug.Log("Game Won!");
                gameWon = true;
                source.PlayOneShot(cheer_sound, volume);
                winningCanvas.active = true;
            }

            print("GAME OVER IS THE FOLLOWING in the ontrigger enter: " + game_over.ToString());

        }
    }
}
