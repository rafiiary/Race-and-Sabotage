using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActions: MonoBehaviour
{
    public AudioClip buttonSound;
    float volume = 1.0f;
    AudioSource source;
    void onAwake()
    {
        source = GetComponent<AudioSource>();
    }
    void PlaySound()
    {
        source.PlayOneShot(buttonSound, volume);
    }
}
