using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetermineStars : MonoBehaviour
{
    public static int forLoopsCompleted, loopsCompleted, conditionalsCompleted, variablesCompleted;
    public static void Start()
    {
        forLoopsCompleted = 0;
        loopsCompleted = 0;
        conditionalsCompleted = 0;
        variablesCompleted = 0;
    }
    public static void doneForLoop(){
        Debug.Log("Finished for loop scene");
        forLoopsCompleted++;
    }
    public static void doneWhileLoop()
    {
        Debug.Log("Finished while loop scene");
        loopsCompleted++;
    }
    public static void doneConditional()
    {
        Debug.Log("Finished conditional scene");
        conditionalsCompleted++;
    }
    public static void doneVariable()
    {
        Debug.Log("Finished variable scene");
        variablesCompleted++;
    }
}
