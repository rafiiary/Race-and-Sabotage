using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float min_x, max_x, min_z, max_y, max_z;
}
public class BoundaryController : MonoBehaviour
{
    public Boundary boundary;
    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().position = new Vector3
        (
            Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.min_x, boundary.max_x),
            Mathf.Clamp(GetComponent<Rigidbody>().position.y, 0.0f, boundary.max_y),
            Mathf.Clamp(GetComponent<Rigidbody>().position.z, boundary.min_z, boundary.max_z)
        );
    }

}
