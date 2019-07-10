using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class NewScene2EndCanvasTrigger : MonoBehaviour
{
    public GameObject drop1;
    public GameObject drop2;
    public GameObject drop3;
    public Canvas EndCanvas;
    private int CollisionCounter = 0;
    private CapsuleCollider collider;
    public GameObject car;
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<CapsuleCollider>();
        EndCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (drop1.transform.childCount > 0 & drop2.transform.childCount > 0 & drop3.transform.childCount > 0)
        {
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds((float)4);
        EndCanvas.gameObject.SetActive(true);
        camera.transform.SetParent(EndCanvas.transform);
        //collider.gameObject.SetActive(false);
        //car.gameOdbject.SetActive(false);
        car.AddComponent<StopMotion>();
    }
}
