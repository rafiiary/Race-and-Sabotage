using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneArray : MonoBehaviour
{
    public static string[] ArrayOfScenes = {"LoadingScreen", "LoadingScreen 1", "LoadingScreen 3", "LoadingScreen 9", "LoadingScreen 6", "LoadingScreen 2", "LoadingScreen 5", "LoadingScreen 7", "LoadingScreenVariables 9", "LoadingScreen 8 AfterIfvsWhileLoop", "LoadingScreen 4", "LoadingScreenVariables 10", "LoadingScreen ChangeTerrain2", "LoadingScreen 8", "Level3Scene2" };

    private static int SceneNumber = 0;

    public void NextScene()
    {
        SceneNumber++;
        if (SceneNumber >= ArrayOfScenes.Length)
        {
            SceneNumber = 0;
        }
        SceneManager.LoadScene(ArrayOfScenes[SceneNumber]);

        //PrintArray();
    }

    public void WrongAnswer()
    {
        NextScene();
        string wrong = ArrayOfScenes[SceneNumber-1];
        for (int i = SceneNumber; i < ArrayOfScenes.Length; i++)
        {
            ArrayOfScenes[i-1] = ArrayOfScenes[i];
        }
        ArrayOfScenes[ArrayOfScenes.Length - 1] = wrong;
        SceneNumber--;

        PrintArray();

    }

    void PrintArray()
    {
        string statement = "THE ARRAY RIGHT NOW IS ";
        for (int i = 0; i < ArrayOfScenes.Length; i++)
        {
            statement += (ArrayOfScenes[i] + " ");
        }

        Debug.Log(statement);

        Debug.Log("AND THE INDEX RN IS " + SceneNumber.ToString());
    }

}
