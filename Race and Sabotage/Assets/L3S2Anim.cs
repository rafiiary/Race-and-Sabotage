using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class L3S2Anim : MonoBehaviour
{
    public GameObject car;
    public GameObject camera;
    public void stuff()
    {
        car.gameObject.SetActive(true);
        car.AddComponent<CarStraightControl>();
        camera.gameObject.SetActive(true);
        Destroy(gameObject);
    }
}
