using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateCamera : MonoBehaviour
{
    public GameObject camera;
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isActiveAndEnabled)
        {
            camera.transform.SetParent(this.transform, false);
            car.SetActive(false);
        }
    }
}
