using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInAndOut : MonoBehaviour
{
    public GameObject background;
    public GameObject RedLoading;

    private bool full = true;
    private Color tmp;
    private Color tmp2;
    // Start is called before the first frame update
    void Start()
    {
        Color tmp = background.GetComponent<Image>().color;
        Color tmp2 = RedLoading.GetComponent<Image>().color;
    }
    void Update()
    {
        Debug.Log(tmp.a);
        if (full)
        {
            if (tmp.a > 0)
            {
                tmp.a -= 1f;
            }
            if (tmp2.a > 0)
            {
                tmp2.a -= 1f;
            }
            if(tmp.a <=0 & tmp2.a <= 0)
            {
                full = false;
            }
        }
        else
        {
            if (tmp.a < 255)
            {
                tmp.a += 1f;
            }
            if (tmp2.a < 255)
            {
                tmp2.a += 1f;
            }
            if (tmp.a >= 255 & tmp2.a >= 255)
            {
                full = true;
            }
        }

        background.GetComponent<Image>().color = tmp;
        RedLoading.GetComponent<Image>().color = tmp2;

    }
}
