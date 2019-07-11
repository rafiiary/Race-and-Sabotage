using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DandDAnim : MonoBehaviour
{
    public GameObject car;
    public GameObject startercanvas;
    public GameObject codecanvas;
    public Camera maincam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showstuff()
    {
        startercanvas.gameObject.SetActive(true);
        codecanvas.gameObject.SetActive(true);
        car.gameObject.SetActive(true);
        maincam.gameObject.SetActive(true);
        Destroy(gameObject);
    }
}
