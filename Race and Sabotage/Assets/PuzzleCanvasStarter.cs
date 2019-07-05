using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleCanvasStarter : MonoBehaviour
{
    public Button ProceedButton;
    public GameObject Car;
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        camera.transform.SetParent(gameObject.transform);
        Car.gameObject.SetActive(false);
        ProceedButton.onClick.AddListener(Proceed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Proceed()
    {
        print("THE CAMERA IS " + camera.ToString());
        Car.gameObject.SetActive(true);
        camera.transform.SetParent(Car.transform);
        gameObject.SetActive(false);
    }


}
