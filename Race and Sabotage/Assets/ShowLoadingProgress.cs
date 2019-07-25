using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowLoadingProgress : MonoBehaviour
{
    public Slider slider;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        string percentage = Mathf.Round(slider.value * 100).ToString();
        text.text = "Loading: " + percentage + "%";
    }
}
