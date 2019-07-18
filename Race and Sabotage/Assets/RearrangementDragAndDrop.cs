using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RearrangementDragAndDrop : MonoBehaviour
{
    public GameObject drop1, drop2, drop3, drop4, drop5;
    public static bool RearrangedCorrect = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("REARRANGEDcORRECT " + RearrangedCorrect.ToString());
        if (drop1.transform.childCount > 0 & drop2.transform.childCount > 0 & drop3.transform.childCount > 0 & drop4.transform.childCount > 0 & drop5.transform.childCount > 0)
        {
            if (drop1.transform.GetChild(0).tag == drop1.tag & drop2.transform.GetChild(0).tag == drop2.tag & drop3.transform.GetChild(0).tag == drop3.tag & drop4.transform.GetChild(0).tag == drop4.tag & drop5.transform.GetChild(0).tag == drop5.tag)
            {
                RearrangedCorrect = true;
            }

        }
        else
        {
            RearrangedCorrect = false;
        }
    }
}
