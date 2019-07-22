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
        if(TurnLeftPanel.active == false)
        {
            GoStraightPanel.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        GoStraightPanel.gameObject.SetActive(true);
        TurnLeftPanel.gameObject.SetActive(false);
    }

  
}
