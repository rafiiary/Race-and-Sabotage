using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_tracks : MonoBehaviour
{
    public GameObject canvas;
    public GameObject car;
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void test()
    {
        canvas.SetActive(false);
        car.SetActive(true);
        camera.transform.SetParent(car.transform);
    }
}
