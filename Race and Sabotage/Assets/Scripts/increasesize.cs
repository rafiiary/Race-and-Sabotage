using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class increasesize : MonoBehaviour
{
    public TextMeshProUGUI text;
    private bool increaseFinished = false;
    private int originalFont;
    // Start is called before the first frame update
    void Start()
    {
        originalFont = text.GetComponent<TextMesh>().fontSize;
    }

    // Update is called once per frame
    void Update()
    {
        ////debug.log(text.GetComponent<TextMesh>().fontSize);
        ////debug.log(text.fontSize);
        if (text.fontSize != 40)
        {
            text.GetComponent<TextMesh>().fontSize += 1;
            increaseFinished = true;
        }
        if (originalFont <= text.fontSize & text.fontSize <= 40 & !increaseFinished)
        {
            text.GetComponent<TextMesh>().fontSize -= 1;
        }
    }
}
