using System.Collections;
using UnityEngine;

public class RandomRotator: MonoBehaviour
{
    public float tumble;

    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
    }
}
