using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartTimeDictate : MonoBehaviour
{
    public Button TestButton;
    public Canvas CodeExecutionCanvas;
    // Start is called before the first frame update
    void Start()
    {
        TestButton.onClick.AddListener(StartExec);
        CodeExecutionCanvas.gameObject.SetActive(false);
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
