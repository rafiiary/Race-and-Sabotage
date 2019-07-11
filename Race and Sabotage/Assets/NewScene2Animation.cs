using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScene2Animation : MonoBehaviour
{
    public GameObject car;
    public void showcar()
    {
        car.gameObject.SetActive(true);
        Destroy(gameObject);
    }
}
