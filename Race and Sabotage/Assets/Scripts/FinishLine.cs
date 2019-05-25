﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject winningCar;
    public GameObject winningCanvas;
    bool gameWon;

    float volume = 1.0f;
    AudioSource source;
    public AudioClip cheer_sound;
    private void Start()
    {
        winningCanvas.active = false;
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
            gameWon = true;
            source.PlayOneShot(cheer_sound, volume);
            winningCanvas.active = true;
        }
    }
}
