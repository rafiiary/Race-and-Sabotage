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
    public void updateSolved(bool hint = false)
    {
        solved = false;
        if (hint)
        {
            solved = true;
        }
        else
        {
            droppedObject = gameObject.transform.GetChild(0).gameObject;
            if (droppedObject != null)
            {
                droppedObjectTag = droppedObject.tag;
                //Debug.Log(droppedObjectTag);
                if (tagName.CompareTo(droppedObjectTag) == 0 || droppedObject.tag == tagName)
                {
                    solved = true;
                }
                else
                {
                    Debug.Log(tagName + droppedObject.tag + (droppedObject.tag == tagName).ToString());
                    solved = false;
                }
            }
        }
    }

    public bool getSolved()
    {
        return solved;
    }
}
