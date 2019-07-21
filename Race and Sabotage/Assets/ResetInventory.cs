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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
