using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepBGMusic : MonoBehaviour
{

    private static KeepBGMusic instance = null;
    public static KeepBGMusic Instance
    {
        get { return instance; }
    }
    /* Don't destroy this object between loads */
    void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
