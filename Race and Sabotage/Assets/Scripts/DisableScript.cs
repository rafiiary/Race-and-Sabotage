using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableScript : MonoBehaviour
{
    public Button proceed;
    public Canvas CanvasToDeactivate;
    public Canvas DragAndDropCanvas;
    //public GameObject CarAI1, CarAI2, CarAI3;
    // Start is called before the first frame update
    void Start()
    {
        proceed.onClick.AddListener(Disabler);
        DragAndDropCanvas.gameObject.SetActive(false);
        //    CarAI1.gameObject.SetActive(false);
        //    CarAI2.gameObject.SetActive(false);
        //    CarAI3.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Disabler()
    {
        CanvasToDeactivate.gameObject.SetActive(false);
        DragAndDropCanvas.gameObject.SetActive(true);
        //CarAI1.gameObject.SetActive(true);
        //CarAI2.gameObject.SetActive(true);
        //CarAI3.gameObject.SetActive(true);
    }


}
