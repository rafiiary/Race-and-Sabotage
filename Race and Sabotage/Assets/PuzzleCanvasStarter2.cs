using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleCanvasStarter2 : MonoBehaviour
{
    public Button ProceedButton;
    public GameObject Car;
    public Camera camera;
    public PuzzleCanvasStarter puzzle;
    public Image wronganswer;
    public Canvas pausecanvas;
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        camera.transform.SetParent(gameObject.transform);
        Car.gameObject.SetActive(false);
        ProceedButton.onClick.AddListener(CheckAnswer);
    }

    // Update is called once per frame
    void Update()
    {
        if (counter > 0)
        {
            wronganswer.gameObject.SetActive(true);
            counter--;
        }
        else
        {
            wronganswer.gameObject.SetActive(false);
        }
    }

    void Proceed()
    {
        print("THE CAMERA IS " + camera.ToString());
        Car.gameObject.SetActive(true);
        camera.transform.SetParent(Car.transform);
        gameObject.SetActive(false);
    }

    void CheckAnswer()
    {
        Debug.Log("first is " + NewSlot.first.ToString());
        Debug.Log("second is " + NewSlot.second.ToString());
        Debug.Log("third is " + NewSlot.third.ToString());
        Debug.Log("fourth is " + NewSlot.fourth.ToString());
        Debug.Log("fifth is " + NewSlot.fifth.ToString());
        if (NewSlot.first && NewSlot.second && NewSlot.third && NewSlot.fourth && NewSlot.fifth)
        {
            Debug.Log("WENT HERE BOYSSSSS");
            //puzzle.gameObject.SetActive(false);
            pausecanvas.gameObject.SetActive(true);
            Car.gameObject.SetActive(true);
            camera.transform.SetParent(Car.transform);
            gameObject.SetActive(false);
        }
        else
        {
            counter = 60;
        }
    }


}
