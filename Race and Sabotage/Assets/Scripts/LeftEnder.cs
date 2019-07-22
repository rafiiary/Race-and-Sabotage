using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftEnder : MonoBehaviour
{
    public GameObject GoStraightPanel;
    public GameObject TurnLeftPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        TurnLeftPanel.gameObject.SetActive(true);
        GoStraightPanel.gameObject.SetActive(false);
    }


}
