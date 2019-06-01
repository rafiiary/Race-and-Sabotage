using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next_level : MonoBehaviour
{
    public GameObject guiObject;
    public string levelToLoad;

    // Use this for initialization
    void Start()
    {
        guiObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        guiObject.SetActive(true);
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        {
            guiObject.SetActive(true);
            if (guiObject.activeInHierarchy == true && Input.GetButtonDown("Use"))
            {
                Application.LoadLevel(levelToLoad);
            }
        }

    }
    void OnTriggerExit()
    {
        guiObject.SetActive(false);
    }
    public void NextLevel(string levelname)
    {
        Application.LoadLevel(levelname);
    }
}
