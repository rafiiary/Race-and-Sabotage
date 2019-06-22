using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pivot_turn : MonoBehaviour
{
    public GameObject pivot;
    public GameObject canvas;
    int pivot_int = 0;
    int canvas_int = 0;
    int times_clicked = 1;
    int pivotStore = 0;
    int canvasStore = 0;
    public static bool needHelp = true;
    // Start is called before the first frame update
    void Start()
    {
        print(canvas.transform.rotation.z * 100);
        if (Mathf.Round(pivot.transform.rotation.y * 100) == 71)
        {
            pivotStore = 90;
        }
        if (Mathf.Round(pivot.transform.rotation.y * 100) == 100)
        {
            pivotStore = 180;
        }
        if (Mathf.Round(pivot.transform.rotation.y * 100) == -71)
        {
            //print(pivot.transform.rotation.y);
            pivotStore = 270;
        }
        if (Mathf.Round(pivot.transform.rotation.y * 100) == 0)
        {
            //print(pivot.transform.rotation.y);
            pivotStore = 0;
        }

        if (Mathf.Round(canvas.transform.rotation.z * 100) == 71)
        {
            canvasStore = 90;
        }
        if (Mathf.Round(canvas.transform.rotation.z * 100) == 100)
        {
            canvasStore = 180;
        }
        if (Mathf.Round(canvas.transform.rotation.z * 100) == -100)
        {
            canvasStore = -180;
        }
        if (Mathf.Round(canvas.transform.rotation.z * 100) == 0)
        {
            canvasStore = 0;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void turn()
    {
        if (times_clicked > 4)
        {
            times_clicked = 1;
        }
        pivot.transform.rotation = Quaternion.Euler(0, pivotStore + times_clicked * 90, 0);
        canvas.transform.rotation = Quaternion.Euler(0, 0, canvasStore - times_clicked * 90);
        //Debug.Log(canvas.transform.rotation.z);
        times_clicked += 1;
        needHelp = false;
    }
}
