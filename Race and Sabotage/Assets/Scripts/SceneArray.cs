using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneArray : MonoBehaviour
{
    public static string[] ArrayOfScenes = {"InfiniteTerrain", "InfiniteTerrain 1", "InfiniteTerrain 2", "InfiniteTerrain 3", "InfiniteTerrain 4", "InfiniteTerrain 5", "InfiniteTerrain 6", "InfiniteTerrain 7", "InfiniteTerrain 8", "InfiniteTerrain 9", "InfiniteTerrain 10", "InfiniteTerrain 11", "InfiniteTerrain 12", "InfiniteTerrain 13", "InfiniteTerrain 14", "InfiniteTerrain 15", "FinishedScene"};

    private int endRange = 0;

	public static int SceneNumber = -1;

    void Update()
    {
        //debug.log(SceneNumber.ToString() + "Scene number");
    }

    public void FirstScene()
    {
        SceneNumber = -1;
        NextScene();
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
        //    //debug.log("TRYING TO FIX BUG");
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

        //debug.log(statement);
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
