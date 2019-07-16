using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChaptersSceneArrayLinker : MonoBehaviour
{
    public string Scene;
    Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SceneLoad);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SceneLoad()
    {
        SetSceneArrayVariables(Scene);
        SceneManager.LoadScene(Scene);
    }

    void SetSceneArrayVariables(string scene)
    {
        for (int i = 0; i < SceneArray.ArrayOfScenes.Length; i++)
        {
            if (scene == SceneArray.ArrayOfScenes[i])
            {
                SceneArray.SceneNumber = i;
                Debug.Log("THE VARIABLE FOR SCENE NUMBER WAS SET");
                break;
            }
        }
    }
}
