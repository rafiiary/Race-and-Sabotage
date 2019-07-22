using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snap : MonoBehaviour
{
    private bool snapped;
    private bool timeDone;
    private bool isIn = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        IEnumerator Example()
        {
            timeDone = false;
            yield return new WaitForSeconds((float)0.2);
            timeDone = true;
        }
        if (isIn)
        {
            if (!snapped)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    snapped = true;
                }
                else if (Input.GetMouseButtonUp(0))
                {
                    snapped = false;
                }
            }
            else
            {
                if (Input.GetMouseButtonDown(0))
                {
                    snapped = true;
                }
                else if (Input.GetMouseButtonUp(0))
                {
                    snapped = false;
                }
            }
        }
    }
}

