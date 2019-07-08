using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loops2Loader : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(loadscene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void loadscene()
    {
        SceneManager.LoadScene("NewD&D");
    }
}
