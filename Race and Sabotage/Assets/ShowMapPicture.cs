using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMapPicture : MonoBehaviour
{
    public Image MapImage;
    private int counter = 200;
    // Start is called before the first frame update
    void Start()
    {
        MapImage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (counter > 0)
        {
            MapImage.gameObject.SetActive(true);
            counter--;
        }
        else
        {
            MapImage.gameObject.SetActive(false);
        }
    }
}
