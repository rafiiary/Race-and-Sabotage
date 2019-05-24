using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfwayTrigger : MonoBehaviour
{
    public GameObject LapCompleteTrigger;
    public GameObject HalfTrigger;

    void OnTriggerEnter()
    {
        LapCompleteTrigger.SetActive(true);
        HalfTrigger.SetActive(false);
    }
}
