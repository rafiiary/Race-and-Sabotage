using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DTwoAnswerKeys : MonoBehaviour
{
    /* Whether the answers are correct or not */
    public GameObject[] destinations = new GameObject[8];
    public static bool allSolved;
    // Start is called before the first frame update
    void Start()
    {
        allSolved = false;
        /* populate the answers array */

    }

    /* Turn solved to true iff all twelve things are in the right place */
    public void checkAnswers()
    {
        allSolved = true;
        foreach (GameObject destination in destinations)
        {
            // this ignores the comment 
            if(destination.tag == "3")
            {
                continue;
            }
            if (!destination.GetComponent<correctPanelOn>().getSolved())
            {
                Debug.Log(destination.tag);
                allSolved = false;
            }
        }
        if (allSolved)
        {
            ////debug.log("All solved!");
        }
    }
}
