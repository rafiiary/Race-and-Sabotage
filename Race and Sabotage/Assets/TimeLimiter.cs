using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLimiter : MonoBehaviour
{
    public Canvas EndCanvas;
    public Canvas TimeoutCanvas;
    private int timer = 4800;
    // Start is called before the first frame update
    void Start()
    {
        EndCanvas.gameObject.SetActive(false);
        TimeoutCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer--;
        if (0 <= timer && timer <= 60)
        {
            TimeoutCanvas.gameObject.SetActive(true);
        }
        if (timer <= 0)
        {
            TimeoutCanvas.gameObject.SetActive(false);
            EndCanvas.gameObject.SetActive(true);
        }
    }
}
