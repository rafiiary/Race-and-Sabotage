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
    // Start is called before the first frame update
    void Start()
    {

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
        pivot.transform.rotation = Quaternion.Euler(0, times_clicked * 90, 0);
        canvas.transform.rotation = Quaternion.Euler(0, 0, times_clicked * 90);
        Debug.Log(canvas.transform.rotation.z);
        times_clicked += 1;
    }
}
