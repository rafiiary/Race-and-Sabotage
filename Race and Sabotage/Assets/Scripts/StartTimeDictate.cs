using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartTimeDictate : MonoBehaviour
{
    public Button TestButton;
    public GameObject CodeExecutionCanvas;
    // Start is called before the first frame update
    void Start()
    {
        TestButton.onClick.AddListener(StartExec);
        Debug.Log("we reached here boysssssss");
        CodeExecutionCanvas.gameObject.SetActive(false);
        Debug.Log("we reached here too lmaooooo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartExec()
    {
        CodeExecutionCanvas.gameObject.SetActive(true);
    }
}
