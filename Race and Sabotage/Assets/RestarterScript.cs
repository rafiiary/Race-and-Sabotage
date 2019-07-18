using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestarterScript : MonoBehaviour
{
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("REACHED HERE BOYS LMAOOOOOO");
        slider.value = 0.9f;
    }
}
