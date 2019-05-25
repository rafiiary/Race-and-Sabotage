using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject winningCar;
    public AudioClip yay_sound;
    bool gameWon;

    float volume = 1.0f;
    AudioSource source;
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
            source.PlayOneShot(yay_sound, volume);
        }
    }
}
