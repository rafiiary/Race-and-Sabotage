using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2SAnimation : MonoBehaviour
{
    public GameObject initialcanvas;
    public GameObject car;

    public void dostuff()
    {
        initialcanvas.gameObject.SetActive(true);
        car.gameObject.SetActive(true);
        Destroy(gameObject);
    }
}
