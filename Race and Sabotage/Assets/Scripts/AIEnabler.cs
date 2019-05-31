using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnabler : MonoBehaviour
{
    public GameObject HUDCanvas;
    public GameObject Car;
    public GameObject CarAI1;
    public GameObject CarAI2;
    public GameObject CarAI3;
    // Start is called before the first frame update
    void Start()
    {
        CarAI3.gameObject.SetActive(false);
        CarAI2.gameObject.SetActive(false);
        CarAI1.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        HUDCanvas.gameObject.SetActive(false);
        CarAI3.gameObject.SetActive(true);
        CarAI2.gameObject.SetActive(true);
        CarAI1.gameObject.SetActive(true);
        Car.gameObject.tag = "Dreamcar01";
    }
}
