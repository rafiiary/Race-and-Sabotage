using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifLoseCanvasActive : MonoBehaviour
{
    public GameObject codeExecution;
    public GameObject car;
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isActiveAndEnabled)
        {
            camera.transform.SetParent(this.transform);
            codeExecution.SetActive(false);
            car.SetActive(false);
        }
    }
    IEnumerator BeforeLose()
    {
        yield return new WaitForSeconds((float)1);
        codeExecution.SetActive(false);
        car.SetActive(false);
    }
}
