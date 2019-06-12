using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class for_loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 5000000; i > 0; i--)
        {
            Debug.Log(i);
            if (i == 2)
            {
                Time.timeScale = 0;
            }
        }

    }
}
