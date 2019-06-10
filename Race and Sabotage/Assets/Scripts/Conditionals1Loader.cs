using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Conditionals1Loader : MonoBehaviour
{
    public Button thisone;
    // Start is called before the first frame update
    void Start()
    {
        thisone.onClick.AddListener(something);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void something()
    {
        SceneManager.LoadScene("Level2Scene");
    }
}
