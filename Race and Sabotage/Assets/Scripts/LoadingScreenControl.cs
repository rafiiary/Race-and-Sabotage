using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScreenControl : MonoBehaviour
{
    public Slider slider;
    public string NextLevel;
    private int counter = 0;
    private float value;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        slider.GetComponent<Slider>().value = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        counter++;
        if (counter % 16 == 0 && slider.GetComponent<Slider>().value <= 0.3)
        {
            slider.GetComponent<Slider>().value += (float)0.01;
        }
        else if (counter % 16  == 0 && slider.GetComponent<Slider>().value >= 0.75)
        {
            slider.GetComponent<Slider>().value += (float)0.01;
        }
        else if (counter % 16 == 0 && slider.GetComponent<Slider>().value > 0.3 && slider.GetComponent<Slider>().value < 0.75)
        {
            slider.GetComponent<Slider>().value += (float)0.01;
        }

        if (slider.GetComponent<Slider>().value >= 1)
        {
            SceneManager.LoadScene(NextLevel);
        }
    }
}
