using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public Button StartButton;
    // Start is called before the first frame update
    void Start()
    {
        StartButton.onClick.AddListener(Starter);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Starter()
    {
        SceneManager.LoadScene("Level1Scene");
    }
}
