using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        entered = false;
        ProceedButtonDAndD.NumberOfWrongGuesses = 0;
        newProceed.NumberofWrongGuesses = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!entered)
        {
            if (ProceedButtonDAndD.NumberOfWrongGuesses == 6 || newProceed.NumberofWrongGuesses == 3)
            {
                check.SetActive(true);
            }
        }
    }
    public void hint()
    {
        if (!entered)
        {
            StartCoroutine(HintCoroutine());
            entered = true;
            ResetingInventory();
            foreach (Transform destination in currentDestination.transform)
            {
                if (destination.GetComponent<correctPanelOn>().tagName == "rightBracket")
                {
                    foreach (Transform choice in currentChoices.transform)
                    {
                        if (choice.gameObject.tag == "rightBracket" & choice.childCount > 0)
                        {
                            choice.GetChild(0).localScale = new Vector3(1.8f, 0.8f);
                            choice.GetChild(0).SetParent(destination, false);
                            destination.GetComponent<correctPanelOn>().updateSolved();
                            break;
                        }
                    }
                }
                if (destination.GetComponent<correctPanelOn>().tagName == "leftBracket")
                {
                    foreach (Transform choice in currentChoices.transform)
                    {
                        if (choice.gameObject.tag == "leftBracket" & choice.childCount > 0)
                        {
                            choice.GetChild(0).localScale = new Vector3(1.8f, 0.8f);
                            choice.GetChild(0).SetParent(destination, false);
                            destination.GetComponent<correctPanelOn>().updateSolved();
                            break;
                        }
                    }
                }
            }
        }
    }
    public void NoHint()
    {
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
        currentChoices = Instantiate(choicesPanelcopy, choicesPanelcopy.transform.parent);
        currentChoices.SetActive(true);
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
