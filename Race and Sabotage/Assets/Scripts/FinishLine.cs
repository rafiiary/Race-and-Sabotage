using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject winningCar;
    bool gameWon;

    float volume = 1.0f;
    AudioSource source;
    public AudioClip cheer_sound;
    private void Start()
    {
        gameWon = false;
    }

    void Awake()
    {

        source = GetComponent<AudioSource>();

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Dreamcar01"))
        {
            Debug.Log("Game Won!");
            source.PlayOneShot(cheer_sound, volume);
        }
    }
}
