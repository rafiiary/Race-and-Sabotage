using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Conditionals2Loader : MonoBehaviour
{
    public Button thisbadboy;
    // Start is called before the first frame update
    void Start()
    {
        thisbadboy.onClick.AddListener(loadscene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void loadscene()
    {
        SceneManager.LoadScene("Change_terrain_chapter2");
    }
}
