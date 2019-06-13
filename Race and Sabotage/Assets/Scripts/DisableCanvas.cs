using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableCanvas : MonoBehaviour
{
    public Button Button;
    public Canvas Canvas;
    public Canvas PauseCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Button.onClick.AddListener(Disappear);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Disappear()
    {
        Canvas.gameObject.SetActive(false);
        PauseCanvas.gameObject.SetActive(true);
    }
}
