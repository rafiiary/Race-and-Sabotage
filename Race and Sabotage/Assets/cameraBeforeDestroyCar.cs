using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraBeforeDestroyCar : MonoBehaviour
{
    public Camera camera;
    public GameObject code;
    public GameObject finish;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        camera.transform.parent = finish.transform;
        StartCoroutine(Example());
        code.SetActive(false);

    }
    IEnumerator Example()
    {
        yield return new WaitForSeconds((float)1);
    }
}
