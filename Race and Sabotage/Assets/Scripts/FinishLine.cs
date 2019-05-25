using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public AudioClip yay;
    bool gameWon;

    float volume = 1.0f;
    private AudioSource source;
    private void Start()
    {
        gameWon = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(!other.gameObject.CompareTag("car1"))
        {
            Debug.Log("Game Won!");
            source.PlayOneShot(yay, volume);
        }
    }
}
