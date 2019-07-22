using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightStarter : MonoBehaviour
{
    public GameObject GoStraightPanel;
    public GameObject TurnRightPanel;
    private bool startTurns = false;
    // Start is called before the first frame update
    void Start()
    {
        TurnRightPanel.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (!startTurns)
        {
            GoStraightPanel.gameObject.SetActive(false);
        }
        if(TurnRightPanel.active == false)
        {
            GoStraightPanel.gameObject.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        startTurns = true;
        TurnRightPanel.gameObject.SetActive(false);
        GoStraightPanel.gameObject.SetActive(true);
    }
}
