using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScene2BugFix : MonoBehaviour
{
    public GameObject car;
    public GameObject pauseMenu;
    private bool entered = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!entered)
        {
            if (car.active == false)
            {
                Debug.Log("false");
                pauseMenu.SetActive(false);
            }
            else
            {
                Debug.Log("true");
                pauseMenu.SetActive(true);
                entered = true;
            }
        }
    }
}
