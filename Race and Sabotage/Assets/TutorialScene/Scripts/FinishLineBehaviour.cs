using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineBehaviour : MonoBehaviour
{
    public GameObject instructionController;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "ColliderBody")
        {
            Debug.Log("Hit manz");
            instructionController.GetComponent<InstructionController>().reachedEnd();
            MoneyCounter.UserMoney += 25;
        }
    }
}
