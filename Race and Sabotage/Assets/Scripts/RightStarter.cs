using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightStarter : MonoBehaviour
{
    public GameObject GoStraightPanel;
    public GameObject TurnRightPanel;
    // Start is called before the first frame update
    void Start()
    {
        TurnRightPanel.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

     void OnCollisionEnter(Collision collision)
    {
        Debug.Log("PLS WORK GODDAMNIT");
        TurnRightPanel.gameObject.SetActive(false);
        GoStraightPanel.gameObject.SetActive(true);
    }
}
