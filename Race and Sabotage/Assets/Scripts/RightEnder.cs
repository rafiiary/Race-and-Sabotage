using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightEnder : MonoBehaviour
{
    public GameObject GoStraightPanel;
    public GameObject TurnRightPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

     void OnCollisionEnter(Collision collision)
    {
        Debug.Log("I PRAY U, WORK PLS");
        GoStraightPanel.gameObject.SetActive(false);
        TurnRightPanel.gameObject.SetActive(true);
    }
}
