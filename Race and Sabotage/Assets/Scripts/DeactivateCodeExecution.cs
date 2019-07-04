using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateCodeExecution : MonoBehaviour
{
    public GameObject codeExecution;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isActiveAndEnabled)
        {
            codeExecution.SetActive(false);
        }
    }
}
