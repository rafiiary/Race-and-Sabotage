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
            ////debug.log("MainAudio is null");
        }
        else
        {
            ////debug.log("ControllerScript is null");
        }
        ////debug.log("Button clicked");
        ControllerScript.nextSong();
    }

}
