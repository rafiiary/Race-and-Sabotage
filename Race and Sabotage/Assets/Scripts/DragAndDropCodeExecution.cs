using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropCodeExecution : MonoBehaviour
{
    public GameObject if_statement;
    public GameObject if_else_statement;
    public GameObject if_content;
    public GameObject if_else_content;
    public GameObject containinTrigger;
    public triggerStaticVariable trigger;
    // Start is called before the first frame update
    void Start()
    {
        trigger = containinTrigger.GetComponent<triggerStaticVariable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger.turning_left)
        {
            //debug.log("turning_left!");
        }
    }
}
