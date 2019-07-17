using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLoseCanvas : MonoBehaviour
{
    public Canvas canvas;
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        canvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        canvas.gameObject.SetActive(true);
        car.gameObject.SetActive(false);
    }
}
