using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPause : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource theSource;
    void Start()
    {
        theSource = GetComponent<AudioSource>();
        theSource.ignoreListenerPause = true;
    }
}
