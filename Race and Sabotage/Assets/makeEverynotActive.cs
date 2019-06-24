using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeEverynotActive : MonoBehaviour
{
    public GameObject one, two, three, four, five, six;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void makeThingsNotActive()
    {
        one.SetActive(false);
        two.SetActive(false);
        three.SetActive(false);
        four.SetActive(false);
        five.SetActive(false);
        six.SetActive(false);
    }
}
