using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1SceneAnimation : MonoBehaviour
{
    public GameObject startercanvas;
    public GameObject car;
    public GameObject dndcanvas;
    public void showstuff()
    {
        car.gameObject.SetActive(true);
        startercanvas.gameObject.SetActive(true);
        dndcanvas.gameObject.SetActive(true);
		Destroy(gameObject);
    }
}
