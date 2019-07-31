using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop2Angle : MonoBehaviour
{
    public GameObject drop2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (drop2.transform.childCount > 0)
        {
            ////debug.log("DRAG AND DROP 2 ANGLE TRYING TO FIX THE TIMESCALE PROBLEM");
            Time.timeScale = 1;
            AudioListener.pause = false;
        }
    }
}
