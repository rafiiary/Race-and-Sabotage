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
    public TextMeshProUGUI LoadingText;
    private Slider slider;

    private bool full = true;
    private Color tmp;
    private Color tmp2;
    private Color Loading;
    private float transparency1;
    private float transparency2;
    private bool timeDone;
    private float transparency3;
    // Start is called before the first frame update
    void Start()
    {
        speedOfFade = 0.02f;
        slider = gameObject.GetComponent<Slider>();

    }
    void Update()
    {
        Color tmp = background.GetComponent<Image>().color;
        Color tmp2 = RedLoading.GetComponent<Image>().color;
        Color Loading= LoadingText.GetComponent<TextMeshProUGUI>().color;
        transparency1 = tmp.a;
        transparency2 = tmp2.a;
        transparency3 = Loading.a;
        if (full)
        {
            //debug.log(tmp);
            if (transparency1 >= 0)
            {
                transparency1 -= speedOfFade;
                transparency3 -= speedOfFade;
            }
            if (transparency2 >= 0)
            {
                transparency2 -= speedOfFade;
            }
            if(transparency1 <= 0 & transparency2 <= 0)
            {
                full = false;
            }
        }
        else
        {
            if (transparency1 <= 1)
            {
                transparency1 += speedOfFade;
                transparency3 += speedOfFade;
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
        //debug.log(transparency3);
        LoadingText.color = new Color(Loading.r, Loading.g, Loading.b, transparency3);
        LoadingText.text = "Loading... " + Mathf.Round(slider.value * 100).ToString() + "%";

    }
}
