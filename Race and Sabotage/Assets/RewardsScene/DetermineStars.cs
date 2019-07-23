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
        forLoopsCompleted++;
    }
    public static void doneWhileLoop()
    {
        loopsCompleted++;
    }
    public static void doneConditional()
    {
        conditionalsCompleted++;
    }
    public static void doneVariable()
    {
        variablesCompleted++;
    }
}
