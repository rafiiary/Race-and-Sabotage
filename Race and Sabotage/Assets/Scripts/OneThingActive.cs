using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneThingActive : MonoBehaviour
{
    public GameObject one;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void active()
    {
        one.SetActive(true);
    }
}
