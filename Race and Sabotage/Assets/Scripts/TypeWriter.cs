using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TypeWriter : MonoBehaviour
{
    public TMP_Text displayedText;
    public TMP_Text inputText;
    public TMP_Text italicizedText;
    private string outputText = null;
    private int i = -1;
    private bool done;
    private bool changed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!done)
        {
            displayedText.text = TypeWriteText(inputText.text);
        }
        else
        {
            if (!changed)
            {
                displayedText.text = italicizedText.text;
                changed = true;
            }
        }
    }

    private string TypeWriteText(string text)
    {
        i++;
        char[] characters = text.ToCharArray();
        outputText = outputText + characters[i].ToString();
        if (i == (characters.Length - 1))
        {
            done = true;
        }
        return outputText;
    }
}
