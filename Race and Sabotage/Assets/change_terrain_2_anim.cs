using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_terrain_2_anim : MonoBehaviour
{
	public GameObject timedcanvas;
    public GameObject turntablecanvas;
    public void stuff()
	{
        timedcanvas.gameObject.SetActive(true);
        turntablecanvas.gameObject.SetActive(true);
	}
}
