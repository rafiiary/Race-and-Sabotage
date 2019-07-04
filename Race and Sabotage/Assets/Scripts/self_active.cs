using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class self_active : MonoBehaviour
{
    public GameObject self;
    public GameObject pause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(self.active == true)
        {
            pause.SetActive(true);
        }
    }
}
