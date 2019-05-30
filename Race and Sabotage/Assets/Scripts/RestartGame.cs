using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public Button RestartButton;
    // Start is called before the first frame update
    void Start()
    {
        RestartButton.onClick.AddListener(GameRestarter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GameRestarter()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
