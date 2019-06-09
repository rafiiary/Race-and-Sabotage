using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffle : MonoBehaviour
{
    MusicController ControllerScript;
    GameObject MainAudioGO;
    /* Find the main audio game object playing the songs */
    void Start()
    {
        MainAudioGO = GameObject.Find("MainSoundtrack");
        ControllerScript = MainAudioGO.GetComponent<MusicController>();
    }
    public void shuffle()
    {
        if (MainAudioGO == null)
        {
            Debug.Log("MainAudio is null");
        }
        else
        {
            Debug.Log("ControllerScript is null");
        }
        Debug.Log("Button clicked");
        ControllerScript.nextSong();
    }

}
