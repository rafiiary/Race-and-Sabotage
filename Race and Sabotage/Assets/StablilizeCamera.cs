using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StablilizeCamera : MonoBehaviour
{
    public GameObject car;
    private float y;
    // Start is called before the first frame update
    void Start()
    {
        y = transform.position.y;    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(car.transform.position.x, y, car.transform.position.z);
    }
}
