using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_terrain_wobble_help : MonoBehaviour
{
    private wobble wobbleScript;
    private bool returnedToNormal = false;
    // Start is called before the first frame update
    void Start()
    {
        pivot_turn.needHelp = true;

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Example((float)10));
        
    }
    IEnumerator Example(float time)
    {
        yield return new WaitForSeconds((float)time);
        if (pivot_turn.needHelp == true)
        {
            GetComponent<wobble>().enabled = true;
        }
        else
        {
            GetComponent<wobble>().enabled = false;

        }
            
    }
}
