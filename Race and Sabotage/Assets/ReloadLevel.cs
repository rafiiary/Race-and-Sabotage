using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReloadLevel : MonoBehaviour
{
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(LoadTheLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadTheLevel()
    {
        SceneManager.LoadScene("Level3Scene2");
    }
    
}
