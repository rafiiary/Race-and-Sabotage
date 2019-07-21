using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetInventory : MonoBehaviour
{
    public GameObject choicesPanelcopy;
    public GameObject currentChoices;
    //public GameObject destinationcopy;
    public GameObject currentDestination;
    public GameObject ResetButton;
    public GameObject proceedButton;
    public GameObject check;
    bool entered = false;
    public GameObject bracketKnowledge;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(ProceedButtonDAndD.NumberOfWrongGuesses);
        if (!entered)
        {
            if (ProceedButtonDAndD.NumberOfWrongGuesses == 6)
            {
                check.SetActive(true);
            }
        }
    }
    public void hint()
    {
        StartCoroutine(HintCoroutine());
        entered = true;
        ResetingInventory();
        Debug.Log("it has reached 6");
        foreach (Transform destination in currentDestination.transform)
        {
            if (destination.GetComponent<correctPanelOn>().tagName == "rightBracket")
            {
                foreach (Transform choice in currentChoices.transform)
                {
                    if (choice.gameObject.tag == "rightBracket")
                    {
                        choice.SetParent(destination, false);
                        choice.localScale = new Vector3(2.2f, 0.8f);
                        break;
                    }
                }
            }
            if (destination.GetComponent<correctPanelOn>().tagName == "leftBracket")
            {
                foreach (Transform choice in currentChoices.transform)
                {
                    if (choice.gameObject.tag == "leftBracket")
                    {
                        choice.SetParent(destination, false);
                        choice.localScale = new Vector3(2.2f, 0.8f);
                        break;
                    }
                }
            }
        }
    }
    public void NoHint()
    {
        Debug.Log("I DONT WANT A HINT");
        entered = true;
        check.SetActive(false);
    }
    public void ResetingInventory()
    {
        Destroy(currentChoices);
        foreach (Transform child in currentDestination.transform)
        {
            foreach (Transform child2 in child)
            {
                Destroy(child2.gameObject);
            }
        }
        //Destroy(currentDestination);
        currentChoices = Instantiate(choicesPanelcopy, choicesPanelcopy.transform.parent);
        currentChoices.SetActive(true);
        //currentDestination = Instantiate(destinationcopy, destinationcopy.transform.parent);
        //currentDestination.SetActive(true);
        currentChoices.transform.SetSiblingIndex(0);
        ResetButton.transform.SetSiblingIndex(-1);
        proceedButton.transform.SetSiblingIndex(-1);
    }
    IEnumerator HintCoroutine()
    {
        if (!entered)
        {
            check.SetActive(false);
            bracketKnowledge.SetActive(true);
            proceedButton.SetActive(false);
            ResetButton.SetActive(false);
            yield return new WaitForSeconds((float)6);
            proceedButton.SetActive(true);
            bracketKnowledge.SetActive(false);
            ResetButton.SetActive(true);
        }
    }

}
