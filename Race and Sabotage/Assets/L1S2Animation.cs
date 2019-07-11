using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1S2Animation : MonoBehaviour
{
    public GameObject dndcanvas;
    public GameObject cam2;

    public void showstuff()
    {
        dndcanvas.gameObject.SetActive(true);
        cam2.gameObject.SetActive(true);
        Destroy(gameObject);
    }
}
