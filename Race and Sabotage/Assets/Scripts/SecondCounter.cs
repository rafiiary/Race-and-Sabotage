using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCounter : MonoBehaviour
{
    public GameObject Hint;
    public float seconds;
    bool entered_enumerate;
    change_terrain_increaseSize HintScript;
    // Start is called before the first frame update
    void Start()
    {
        entered_enumerate = false;
        HintScript = Hint.GetComponent<change_terrain_increaseSize>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("callHint");
        if (entered_enumerate)
        {
            ////debug.log("enabled");
            HintScript.enabled = true;
        }
        else
        {
            HintScript.enabled = false;

        }
        //HintScript.enabled = false;
    }

    IEnumerator callHint()
    {
        yield return new WaitForSeconds(1.3f);
        ////debug.log("entered the waiting function");
        entered_enumerate = true;
    }


}
