using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish_collide : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        canvas.SetActive(true);
    }
}
