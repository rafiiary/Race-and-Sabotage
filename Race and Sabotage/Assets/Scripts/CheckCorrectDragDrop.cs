using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckCorrectDragDrop : MonoBehaviour
{
    public Image incorrectimage;
    public Button proceedbutton;
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        proceedbutton.onClick.AddListener(CheckDragDrop);
    }

    // Update is called once per frame
    void Update()
    {
        //if (counter > 60)
        //{
        //    incorrectimage.gameObject.SetActive(true);
        //    counter--;
        //}
        //else
        //{
        //    incorrectimage.gameObject.SetActive(false);
        //}
    }

    void CheckDragDrop()
    {
        counter = 60;
    }


}
