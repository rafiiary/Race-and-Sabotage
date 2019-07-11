using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraPositionSetter : MonoBehaviour
{
    public Camera camera;
    public GameObject car;
    public Button proceed;

    // Start is called before the first frame update
    void Start()
    {
        proceed.onClick.AddListener(setcamposition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setcamposition()
    {
        camera.transform.SetParent(car.transform);
        Quaternion carrotation = car.transform.rotation;
        camera.transform.rotation = carrotation;
        camera.transform.position = new Vector3(car.transform.position.x + 4, car.transform.position.y + 3, car.transform.position.z + 5);
        
    }
}
