using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class correctPanelOn : MonoBehaviour
{
    public string tagName;
    bool solved;
    GameObject droppedObject;
    string droppedObjectTag;
    // Start is called before the first frame update
    void Start()
    {
        droppedObjectTag = "nah";
        solved = false;
    }

    // Update is called once per frame
    public void updateSolved()
    {
        droppedObject = gameObject.transform.GetChild(0).gameObject;
        if (droppedObject != null)
        {
            droppedObjectTag = droppedObject.tag;
            if (tagName.CompareTo(droppedObjectTag) == 0)
            {
                solved = true;
            }
            else
            {
                Debug.Log("false");
                solved = false;
            }
        }
    }

    public bool getSolved()
    {
        return solved;
    }
}
