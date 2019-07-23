using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawStars : MonoBehaviour
{
    public Sprite fullStar;
    public Sprite emptyStar;
    public GameObject[] forloop = new GameObject[4];
    public GameObject[] loop = new GameObject[3];
    public GameObject[] conditional = new GameObject[4];
    public GameObject[] variable = new GameObject[4];

    public void Start()
    {
        updateStars();
    }
    public void updateStars()
    {
        //Update for loops:
        int i = 0;
        while(i < DetermineStars.forLoopsCompleted)
        {
            Debug.Log("Entered for loops loop");
            forloop[i].GetComponent<Image>().sprite = fullStar;
            i++;
        }

        //Update loops:
        i = 0;
        while(i < DetermineStars.loopsCompleted)
        {
            loop[i].GetComponent<Image>().sprite = fullStar;
            i++;
        }

        //Update conditional
        i = 0;
        while(i < DetermineStars.conditionalsCompleted)
        {
            conditional[i].GetComponent<Image>().sprite = fullStar;
            i++;
        }

        //Update variable
        i = 0;
        while(i < DetermineStars.variablesCompleted)
        {
            variable[i].GetComponent<Image>().sprite = fullStar;
            i++;
        }
    }
}
