using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class if_active : MonoBehaviour
{
    public GameObject lose;
    public GameObject win;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lose.active == true)
        {
            Destroy(win);
        }
    }
}
