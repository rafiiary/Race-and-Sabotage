using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneArray : MonoBehaviour
{
    public static string[] ArrayOfScenes = {"Loading1", "Loading2", "Loading3", "Loading4", "Loading6", "Loading5", "Loading7", "Loading8", "Loading9", "Loading10", "Loading11","Loading12", "Loading13", "Loading14", "Loading15", "Loading16", "FinishedScene"};

    private int endRange = 0;

	public static int SceneNumber = -1;

    void Update()
    {
        Debug.Log(SceneNumber.ToString() + "Scene number");
    }
    public void NextScene()
    {
        if (SceneNumber >= ArrayOfScenes.Length)
        {
            SceneNumber = 0;
        }
        SceneNumber++;
        SceneManager.LoadScene(ArrayOfScenes[SceneNumber]);

        PrintArray();
    }

    public void LoadFirstLevel()
	{
        SceneManager.LoadScene(ArrayOfScenes[SceneNumber]);
        SceneNumber++;
	}

    public void WrongAnswer()
    {
        //if (SceneNumber == ArrayOfScenes.Length - 2)
        //{
        //    Debug.Log("TRYING TO FIX BUG");
        //    SceneManager.LoadScene(ArrayOfScenes[SceneNumber]);
        //    //SceneNumber--;
        //}
        //else
        //{
        //    NextScene();
        //    string wrong = ArrayOfScenes[SceneNumber - 1];
        //    for (int i = SceneNumber; i < ArrayOfScenes.Length; i++)
        //    {
        //        ArrayOfScenes[i - 1] = ArrayOfScenes[i];
        //    }
        //    ArrayOfScenes[ArrayOfScenes.Length - 1] = wrong;
        //    SceneNumber--;

        //    string FinishedScene = ArrayOfScenes[ArrayOfScenes.Length - 2];
        //    string WrongScene = ArrayOfScenes[ArrayOfScenes.Length - 1];
        //    ArrayOfScenes[ArrayOfScenes.Length - 2] = WrongScene;
        //    ArrayOfScenes[ArrayOfScenes.Length - 1] = FinishedScene;
        //    PrintArray();
        //}

        SetRangeNumbers();

        if (SceneNumber == endRange - 1)
        {
            //load the current scene
            SceneManager.LoadScene(ArrayOfScenes[SceneNumber]);
        }
        else
        {
            NextScene();

            string wrong = ArrayOfScenes[SceneNumber - 1];

            for (int k = SceneNumber; k < endRange; k++) //  point is, you take the scene at startrange and put it on endrange
            {
                ArrayOfScenes[k - 1] = ArrayOfScenes[k];
            }
            ArrayOfScenes[endRange - 1] = wrong;
            SceneNumber--;
        }
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
    }

    void SetRangeNumbers()
    {
        if (SceneNumber < 4)
        {
            endRange = 4;
        }
        else if (SceneNumber < 8)
        {
            endRange = 8;
        }
        else if (SceneNumber < 12)
        {
            endRange = 12;
        }
        else
        {
            endRange = ArrayOfScenes.Length - 1;
        }
    }

}
