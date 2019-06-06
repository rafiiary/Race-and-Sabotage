using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_for_children : MonoBehaviour
{
    public GameObject arrows;
    // Start is called before the first frame update
    void Start()
    {
        arrows.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount > 0)
        {
            arrows.SetActive(true);
        }
    }
}
