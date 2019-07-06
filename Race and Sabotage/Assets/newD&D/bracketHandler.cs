using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class bracketHandler : MonoBehaviour
{
    int leftBracketRemain = 3;
    int rightBracketRemain = 3;
    public TextMeshProUGUI leftBracketText;
    public TextMeshProUGUI rightBracketText;
    // Start is called before the first frame update
    void Start()
    {
        updateTextBrackets();
    }

    void updateTextBrackets()
    {
        leftBracketText.text = "Left Brackets: " + leftBracketRemain.ToString();
        rightBracketText.text = "Right Brackets: " + rightBracketRemain.ToString();
    }

    public void decreaseLeft()
    {
        if (leftBracketRemain > 0)
        {
            leftBracketRemain--;
            updateTextBrackets();
        }
    }
    public void decreaseRight()
    {
        if (rightBracketRemain > 0)
        {
            rightBracketRemain--;
            updateTextBrackets();
        }
    }
}
