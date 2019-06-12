using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderedLoading : MonoBehaviour
{
    public Canvas InitialCanvas;
    public Canvas LaterCanvas;
    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        InitialCanvas.gameObject.SetActive(true);
        LaterCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
