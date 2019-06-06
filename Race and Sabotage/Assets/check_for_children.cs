using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class check_for_children : MonoBehaviour
{
    public GameObject arrows;
    public GameObject before_text;
    public GameObject after_text;
    // Start is called before the first frame update
    void Start()
    {
        arrows.SetActive(false);
        after_text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount > 0)
        {
            arrows.SetActive(true);
            before_text.SetActive(false);
            after_text.SetActive(true);
        }
    }
}
