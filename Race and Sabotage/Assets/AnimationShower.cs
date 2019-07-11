using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class AnimationShower : MonoBehaviour
{
    public Canvas puzzlecanvas;
    public Camera flybyCamera;
    public Camera originalCamera;
    private bool entered = false;
    public void CameraSwitching()
    {
        if (!entered)
        {
            Debug.Log("Camera switchin beginning boyzzzzz YEET");
            puzzlecanvas.gameObject.SetActive(true);
            entered = true;
        }
    }
}
