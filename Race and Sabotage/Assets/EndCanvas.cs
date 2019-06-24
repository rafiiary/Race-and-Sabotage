using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCanvas : MonoBehaviour
{
    public Canvas EndingCanvas;
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        //EndingCanvas.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        EndingCanvas.gameObject.SetActive(true);
        car.gameObject.SetActive(false);
        //TimeLimiter.timer = 0;
    }
}
