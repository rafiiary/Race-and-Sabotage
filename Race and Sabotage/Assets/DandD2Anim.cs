using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DandD2Anim : MonoBehaviour
{
    public GameObject startercanvas;
    public GameObject camera;
    public GameObject codeexec;
    public void dostuff()
    {
        //codeexec.gameObject.SetActive(true);
        camera.gameObject.SetActive(true);
        startercanvas.gameObject.SetActive(true);
        Destroy(gameObject);
    }
}
