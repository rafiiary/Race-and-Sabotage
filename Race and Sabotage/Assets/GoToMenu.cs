using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{
    public Button gotomenu;
    // Start is called before the first frame update
    void Start()
    {
        gotomenu.onClick.AddListener(ToMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
