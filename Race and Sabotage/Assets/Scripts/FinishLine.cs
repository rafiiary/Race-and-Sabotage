using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    bool gameWon;
    private void Start()
    {
        gameWon = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(!other.gameObject.CompareTag("car1"))
        {
            Debug.Log("Game Won!");
        }
    }
}
