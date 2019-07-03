using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Final_scene_scroll : MonoBehaviour
{
    public GameObject level2button;
    public GameObject level3button;
    public GameObject level4button;
    public TextMeshProUGUI Label;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Label.text);
        if (Label.text == "Final Chapter")
        {
            level3button.SetActive(false);
            level2button.SetActive(false);
            level4button.SetActive(false);
        }
        else if (Label.text == "Variables")
        {
            level3button.SetActive(false);
            level4button.SetActive(false);
            level2button.SetActive(true);
        }
        else if (Label.text == "Conditions")
        {
            level4button.SetActive(false);
            level3button.SetActive(true);
            level2button.SetActive(true);
        }
        else
        {
            level3button.SetActive(true);
            level2button.SetActive(true);
            level4button.SetActive(true);
        }
    }
}
