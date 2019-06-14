using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeHideScript : MonoBehaviour
{
    public GameObject LeftTurn, RightTurn, GoStraight;
    // Start is called before the first frame update
    void Start()
    {
        LeftTurn.gameObject.SetActive(true);
        RightTurn.gameObject.SetActive(true);
        GoStraight.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
