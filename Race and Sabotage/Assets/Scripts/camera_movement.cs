using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{

    private Rigidbody rb;
    private float y_value;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        y_value = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > y_value)
        {
            transform.position = new Vector3(transform.position.x, y_value, transform.position.z);
        }
    }
}
