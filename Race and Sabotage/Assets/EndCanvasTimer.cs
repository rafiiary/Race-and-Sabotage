using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityStandardAssets.Utility;

public class EndCanvasTimer : MonoBehaviour
{
    public Canvas EndCanvas;
    private int CollisionCounter = 0;
    private CapsuleCollider collider;
    public GameObject car;
    public GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<CapsuleCollider>();
        EndCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "ColliderBody")
        {
            CollisionCounter++;
            if (CollisionCounter >= 3)
            {
                EndCanvas.gameObject.SetActive(true);
                camera.transform.SetParent(EndCanvas.transform);
                collider.gameObject.SetActive(false);
                car.gameObject.SetActive(false);
            }
        }
    }
}
