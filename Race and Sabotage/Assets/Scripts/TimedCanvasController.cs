using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimedCanvasController : MonoBehaviour
{
    public Canvas TimedCanvas;
    public Canvas NextCanvas;
    private int time;
    // Start is called before the first frame update
    void Start()
    {
        TimedCanvas.gameObject.SetActive(true);
        NextCanvas.gameObject.SetActive(false);
        time = 500;
    }

    // Update is called once per frame
    void Update()
    {
        time--;
        if (time < 0)
        {
            TimedCanvas.gameObject.SetActive(false);
            NextCanvas.gameObject.SetActive(true);
        }
    }
}
