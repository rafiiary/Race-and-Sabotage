using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DandDHint : MonoBehaviour
{
    public GameObject currentDestination;
    public GameObject reset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ProceedButtonDAndD.NumberOfWrongGuesses == 3)
        {
            foreach (Transform child in currentDestination.transform)
            {
                foreach (Transform child2 in child)
                {
                    Destroy(child2.gameObject);
                }
            }
            reset.GetComponent<ResetInventory>().ResetingInventory();
        }
    }
}
