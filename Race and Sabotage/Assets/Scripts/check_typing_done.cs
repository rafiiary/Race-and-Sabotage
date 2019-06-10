using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_typing_done : MonoBehaviour
{
    // Start is called before the first frame update
    TypeWriter check;
    public GameObject button;
    void Start()
    {
        check = GetComponent<TypeWriter>();
        button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(check.done);
        if (check.done)
        {
            button.SetActive(true);
        }
        
    }
}
