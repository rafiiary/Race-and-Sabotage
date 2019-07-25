using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FadeInAndOut : MonoBehaviour
{
    public GameObject background;
    public GameObject RedLoading;
    public float speedOfFade = 0.02f;
    //public TextMeshProUGUI LoadingText;

    private bool full = true;
    private Color tmp;
    private Color tmp2;
    //private Color Loading;
    private float transparency1;
    private float transparency2;
    private bool timeDone;
    //private float transparency3;
    // Start is called before the first frame update
    void Start()
    {
        speedOfFade = 0.02f;

    }
    void Update()
    {
        Color tmp = background.GetComponent<Image>().color;
        Color tmp2 = RedLoading.GetComponent<Image>().color;
        //Color Loading= LoadingText.GetComponent<Image>().color;
        transparency1 = tmp.a;
        transparency2 = tmp2.a;
        //transparency3 = Loading.a;
        if (full)
        {
            Debug.Log(tmp);
            if (transparency1 >= 0)
            {
                Debug.Log(tmp);
                transparency1 -= speedOfFade;
                //transparency3 -= 1;
            }
            if (transparency2 >= 0)
            {
                Debug.Log(tmp);
                transparency2 -= speedOfFade;
            }
            if(transparency1 <= 0 & transparency2 <= 0)
            {
                Debug.Log(tmp);
                full = false;
            }
        }
        else
        {
            if (transparency1 <= 1)
            {
                transparency1 += speedOfFade;
                //transparency3 += 1;
            }
            if (transparency2 <= 1)
            {
                transparency2 += speedOfFade;
            }
            if (transparency1 >= 1 & transparency2 >= 1)
            {
                full = true;
                //LoadingText.color = new Color32(255, 255, 255, 255);
            }

        }
        background.GetComponent<Image>().color = new Color(tmp.r, tmp.g, tmp.b, transparency1);
        RedLoading.GetComponent<Image>().color = new Color(tmp2.r, tmp2.g, tmp2.b, transparency2);
        //LoadingText.color = new Color(Loading.r, Loading.g, Loading.b, transparency3);

    }
}
