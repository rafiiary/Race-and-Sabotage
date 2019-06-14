using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftStarter : MonoBehaviour
{
    public GameObject GoStraightPanel;
    public GameObject TurnLeftPanel;
    // Start is called before the first frame update
    void Start()
    {
        TurnLeftPanel.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter(Collision collision)
    {
        Debug.Log("GOT HERE LMAO");
        GoStraightPanel.gameObject.SetActive(true);
        TurnLeftPanel.gameObject.SetActive(false);
    }
}
