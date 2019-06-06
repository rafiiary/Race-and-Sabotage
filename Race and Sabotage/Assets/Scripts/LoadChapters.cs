using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadChapters : MonoBehaviour
{
    public Button GoToChapters;
    // Start is called before the first frame update
    void Start()
    {
        GoToChapters.onClick.AddListener(gotochaps);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void gotochaps()
    {
        SceneManager.LoadScene("ChaptersScene");
    }
}
