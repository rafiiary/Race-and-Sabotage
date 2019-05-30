using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableScript : MonoBehaviour
{
    public Button proceed;
    public Canvas CanvasToDeactivate;
    public Canvas DragAndDropCanvas;
    // Start is called before the first frame update
    void Start()
    {
        proceed.onClick.AddListener(Disabler);
        DragAndDropCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Disabler()
    {
        CanvasToDeactivate.gameObject.SetActive(false);
        DragAndDropCanvas.gameObject.SetActive(true);
    }


}
