using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCylinderScript : MonoBehaviour
{
    public Canvas WinCanvas;
    public Camera camera;
    public GameObject Car;
    // Start is called before the first frame update
    void Start()
    {
        //WinCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "ColliderBody")
        {
            camera.transform.SetParent(WinCanvas.transform);
            Car.gameObject.SetActive(false);
            WinCanvas.gameObject.SetActive(true);
        }
        
    }
}
