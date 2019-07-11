using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeExecutionTurnOff : MonoBehaviour
{
    public Camera flybyCamera;
    public GameObject code;
    // Start is called before the first frame update
    void Start()
    {
        if (flybyCamera.isActiveAndEnabled)
        {
            code.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
