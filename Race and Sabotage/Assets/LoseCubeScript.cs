using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseCubeScript : MonoBehaviour
{
    public Canvas LoseCanvas;
    public GameObject car;
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        LoseCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "ColliderFront")
        {
            camera.transform.SetParent(LoseCanvas.transform);
            car.gameObject.SetActive(false);
            LoseCanvas.gameObject.SetActive(true);
        }
        
    }
}
