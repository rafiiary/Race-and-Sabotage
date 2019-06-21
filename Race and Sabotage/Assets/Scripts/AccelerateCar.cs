using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerateCar : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(800f, 0f, 0f);      
    }
}
