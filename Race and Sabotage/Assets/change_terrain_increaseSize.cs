using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class change_terrain_increaseSize : MonoBehaviour
{
    public TextMeshProUGUI text_increase;
    public TextMeshProUGUI title;
    private bool entered_enumerate = false;
    private float originalFontSize;
    private bool doneIncrease = false;
    public int increaseUntil;
    // Start is called before the first frame update
    void Start()
    {
        originalFontSize = text_increase.fontSize;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isActiveAndEnabled)
        {
            Debug.Log("this is active");
            StartCoroutine(IncreaseFontSize());
            if (entered_enumerate)
            {
                if (text_increase.fontSize == increaseUntil)
                {
                    doneIncrease = true;
                }
                if (!doneIncrease)
                {
                    text_increase.fontSize += 1;
                    title.fontSize += 1;
                }
                else if (doneIncrease)
                {
                    if (text_increase.fontSize >= originalFontSize)
                    {
                        text_increase.fontSize -= 1;
                        title.fontSize -= 1;
                    }
                }
            }
        }
    }
    IEnumerator IncreaseFontSize()
    {
        yield return new WaitForSeconds((float)1.3);
        Debug.Log("entered the waiting function");
        entered_enumerate = true;

    }
}
