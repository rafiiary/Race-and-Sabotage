using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChapterSceneLoader : MonoBehaviour
{
    public Button level1;
    public Button level2;
    public Button level3;
    // Start is called before the first frame update
    void Start()
    {
        level1.onClick.AddListener(SceneLoad1);
        level2.onClick.AddListener(SceneLoad2);
        level3.onClick.AddListener(SceneLoad3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SceneLoad1()
    {
        SceneManager.LoadScene("Level1Scene");
    }

    void SceneLoad2()
    {
        SceneManager.LoadScene("Change_terrain");
    }

    void SceneLoad3()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
