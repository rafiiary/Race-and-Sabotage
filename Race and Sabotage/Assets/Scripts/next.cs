using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next : MonoBehaviour
{
    public GameObject dissappear;
    public GameObject appear;
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        //button.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void canvas()
    {
        dissappear.SetActive(false);
        appear.SetActive(true);
        button.SetActive(true);
    }
}
