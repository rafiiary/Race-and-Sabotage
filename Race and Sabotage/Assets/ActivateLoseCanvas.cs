using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLoseCanvas : MonoBehaviour
{
    public Canvas canvas;
    public GameObject car;
	public GameObject camera;
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
        camera.transform.SetParent(canvas.transform);
        car.gameObject.SetActive(false);
    }
}
