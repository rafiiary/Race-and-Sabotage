using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next : MonoBehaviour
{
    public GameObject dissappear;
    public GameObject appear;
    public GameObject button;
    public static int checker = 0;
    // Start is called before the first frame update
    void Start()
    {
        //button.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        //if (checker == 1)
        //{
        //    dissappear.gameObject.SetActive(false);
        //    //appear.gameObject.SetActive(true);
        //}
    }
    public void canvas()
    {
        if (dissappear != null)
        {
            dissappear.SetActive(false);
        }
        //Destroy(dissappear);
        appear.SetActive(true);
        //checker = 1;
        button.SetActive(true);
    }
}
