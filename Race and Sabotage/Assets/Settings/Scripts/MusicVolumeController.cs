using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicVolumeController : MonoBehaviour
{
    AudioSource theSpeaker;
    public Slider volumeSlider;
    float volume;
    /* Start the volume at half */
    void Start()
    {
        GameObject MainAudioGO = GameObject.FindGameObjectsWithTag("Speaker")[0];
        theSpeaker = MainAudioGO.GetComponent<AudioSource>();
        volume = 0.5f;
        theSpeaker.volume = volume;
    }

    /* Set the volume and update it whenever it's changed */
    public void updateVolume()
    {
        volume = volumeSlider.value;
        theSpeaker.volume = volume;
    }
    
    public float getVolume()
    {
        return volume;
    }
}
