using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCubeScript : MonoBehaviour
{
    public Camera camera;
    public GameObject car;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        canvas.gameObject.SetActive(true);
        AudioListener.pause = true;
        Time.timeScale = 0;
        Debug.Log("The car collided with " + gameObject.name + " and paused.");
    }

    public void UnpauseCar()
    {
        AudioListener.pause = false;
        Time.timeScale = 1;
        canvas.gameObject.SetActive(false);
        Debug.Log("Car was unpaused");
        BoxCollider boxCollider = gameObject.GetComponent<BoxCollider>();
        boxCollider.isTrigger = false;
        boxCollider.gameObject.SetActive(false);
        camera.transform.SetParent(car.transform);
    }


}
