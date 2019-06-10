using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Conditionals3Loader : MonoBehaviour
{
    public Button thismf;
    // Start is called before the first frame update
    void Start()
    {
        thismf.onClick.AddListener(sceneload);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void sceneload()
    {
        SceneManager.LoadScene("DragAndDrop");
    }
}
