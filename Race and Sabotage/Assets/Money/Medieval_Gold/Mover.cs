using System.Collections;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.up * speed;
    }
    public void setSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
    /*
    [System.Serializable]
    public class Boundary
    {
        public float min_x, max_x, min_y, max_y, min_z, max_z;
    }
    public Boundary boundary;
    void FixedUpdate()
    {
        transform.position = new Vector3
        (
            Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.min_x, boundary.max_x),
            Mathf.Clamp(GetComponent<Rigidbody>().position.y, boundary.min_y, boundary.max_y),
            Mathf.Clamp(GetComponent<Rigidbody>().position.z, boundary.min_z, boundary.max_z)
        );
    }
    */
}
