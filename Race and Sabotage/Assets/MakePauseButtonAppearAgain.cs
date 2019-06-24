using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePauseButtonAppearAgain : MonoBehaviour
{
    public GameObject pause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void makePauseAppear()
    {
        pause.SetActive(true);
    }
}
