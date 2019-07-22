using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCanvas : MonoBehaviour
{
    public GameObject car;
    public GameObject codeExecution;
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isActiveAndEnabled)
        {
            camera.transform.SetParent(this.transform);
            car.SetActive(false);
            codeExecution.SetActive(false);
        }
    }
}
