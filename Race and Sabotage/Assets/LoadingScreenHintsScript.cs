using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreenHintsScript : MonoBehaviour
{
    public string TipType;
    public Text TextField;
    private static int TipIndex = 0;


    string[] VarTips = { "A variable is a programmer assigned value for use within the program.", 
    "Variables allow the programmer to work with values without having to re-derive them.", 
    "Variables have a DATA TYPE, which depends on the type of quantity they store.",
    "Good variable naming is done in two cases: Snake case and Camel case" };


    string[] ConditionalTips = { "Code is executed top to bottom. Use conditionals to control code execution.",
    "Conditions are checked using an 'if' clause", 
    "If the preliminary condition is false, use a 'else if' or 'else'",
    "Conditionals can help clean up convoluted code bases" };


    string[] LoopTips = { "Loops are used to repeatedly execute the same code over data",
    "Couple loops with conditionals to allow more complex code bases!", 
    "There are two main kinds of loops - 'while' loops and 'for' loops",
    "There is an alternative implementation of the while loop called a 'do-while' loop" };


    int choice;
    // Start is called before the first frame update
    void Start()
    {
        switch (TipType)
        {
            case "variable":
                choice = 0;
                break;
            case "conditional":
                choice = 1;
                break;
            case "loop":
                choice = 2;
                break;
            default:
                Debug.Log("YOU RLLY NEED TO CHECK YOUR SPELLINGS FAM");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TipIndex++;
            if (TipIndex >= 4)
            {
                TipIndex = 0;
            }
        }

        switch (TipType)
        {
            case "variable":
                TextField.text = VarTips[TipIndex];
                break;
            case "conditional":
                TextField.text = ConditionalTips[TipIndex];
                break;
            case "loop":
                TextField.text = LoopTips[TipIndex];
                break;
        }
    }


}
