using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerStaticVariable : MonoBehaviour
{
    public bool turning_left;
    private bool inside_trigger;
    // Start is called before the first frame update
    void Start()
    {
        turning_left = false;
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    private void OnTriggerStay(Collider other)
    {
        turning_left = true;
    }
    private void OnTriggerExit(Collider other)
    {
        turning_left = false;
    }
}
