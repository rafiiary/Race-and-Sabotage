using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectsWallCollision : MonoBehaviour
{
    public GameObject losecanvas;
    // Start is called before the first frame update
    void Start()
    {
        losecanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        losecanvas.SetActive(true);
    }
}
