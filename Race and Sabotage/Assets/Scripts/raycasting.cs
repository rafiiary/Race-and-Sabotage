using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycasting : MonoBehaviour
{
    public GameObject raycastObject;
    public GameObject happy;
    public GameObject sad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit objectHit;
        Vector3 fwd = raycastObject.transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(raycastObject.transform.position, fwd * 10, Color.green);
        if (Physics.Raycast(raycastObject.transform.position, fwd, out objectHit, 10))
        {
            ////debug.log("IT IS ABOUT TO COLLIDE");
            happy.SetActive(false);
            sad.SetActive(true);

        }
        else
        {
            happy.SetActive(true);
            sad.SetActive(false);
        }
    }

}
