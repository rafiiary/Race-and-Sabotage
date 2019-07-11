using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoopAnim : MonoBehaviour
{
    public GameObject car;
    public GameObject explaining;
    public void stuff()
    {
        car.gameObject.SetActive(true);
        explaining.gameObject.SetActive(true);
        Destroy(gameObject);
    }
}
