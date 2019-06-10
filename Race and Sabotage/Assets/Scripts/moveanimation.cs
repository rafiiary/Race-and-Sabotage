using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveanimation : MonoBehaviour
{
    private float NewX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NewX = transform.position.x + 1;
        transform.position = new Vector3(NewX, transform.position.y, transform.position.z);
   
    }
}
