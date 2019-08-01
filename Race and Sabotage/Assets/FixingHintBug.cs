using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixingHintBug : MonoBehaviour
{
    private bool AllCorrect = false;
// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(newProceed.otherscript);
    }
    public void GetCorrect()
    {
        int i = 0;
        foreach (Transform child in transform)
        {
            if(child.gameObject.tag == child.GetChild(0).tag)
            {
                i++;
            }
        }
        if (i == 12)
        {
            newProceed.otherscript = true;
        }
    }
}
