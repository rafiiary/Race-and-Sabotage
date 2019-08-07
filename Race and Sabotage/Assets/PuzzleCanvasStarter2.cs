using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleCanvasStarter2 : MonoBehaviour
{
    public Button ProceedButton;
    public GameObject Car;
    public Camera camera;
    public Canvas puzzle;
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
        Car.gameObject.SetActive(true);
        camera.transform.SetParent(Car.transform);
        gameObject.SetActive(false);
    }

    void CheckAnswer()
    {
        if ((NewSlot.first && NewSlot.second && NewSlot.third && NewSlot.fourth && NewSlot.fifth)|| RearrangementDragAndDrop.RearrangedCorrect)
        {
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
