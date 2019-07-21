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
    bool entered = false;
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
                //foreach (Transform choice in currentChoices.transform)
                //{
                //    Debug.Log("looking the currentChoicesnow");
                //    Debug.Log(choice.gameObject.tag);
                //    if (choice.gameObject.tag == "leftBracket")
                //    {
                //        Debug.Log("it has found a left bracket");
                //        foreach (Transform destination in currentDestination.transform)
                //        {
                //           choice.SetParent(destination, false);
                //           choice.localScale = new Vector3(2.2f, 0.8f);
                //        }
                //    }
                //    else if (choice.gameObject.tag == "rightBracket")
                //    {
                //        Debug.Log("it has found a right bracket");
                //        foreach (Transform destination in currentDestination.transform)
                //        {
                //            if ((destination.GetComponent<correctPanelOn>().tagName == "rightBracket"))
                //            {
                //                Debug.Log("setting the parent now");
                //                choice.SetParent(destination, false);
                //                choice.localScale = new Vector3(1.8f, 0.75f);
                //            }
                //        }
                //    }
                //}
            }
        }
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
}
