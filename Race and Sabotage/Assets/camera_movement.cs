using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{

    private Rigidbody rb;
    public Transform player;
    public Vector3 lookOffset = new Vector3(0, 1, 0);
    public float distance = 5;
    public float cameraSpeed = 8;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookPosition = player.position + lookOffset;
        this.transform.LookAt(lookPosition);

        if (Vector3.Distance(this.transform.position, lookPosition) > distance)
        {
            this.transform.Translate(0, 0, cameraSpeed * Time.deltaTime);
        }
    }
}
