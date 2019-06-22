using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCoin : MonoBehaviour
{
    float speed;
    Vector3 rotateVec;
    private void Start()
    {
        rotateVec = new Vector3(0f, 1f, 0f);
        speed = 100f;
    }
    private void FixedUpdate()
    {
        transform.Rotate(rotateVec * speed * Time.deltaTime);
    }
}
