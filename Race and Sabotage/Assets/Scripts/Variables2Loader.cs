using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Variables2Loader : MonoBehaviour
{
    public Button something;
    // Start is called before the first frame update
    void Start()
    {
        something.onClick.AddListener(loadscene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void loadscene()
    {
        SceneManager.LoadScene("Change_terrain_chapter1");
    }
}
