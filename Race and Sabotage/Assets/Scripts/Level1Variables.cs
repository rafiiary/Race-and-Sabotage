using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level1Variables : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public TextMeshProUGUI CurrentSpeed;
    public TextMeshProUGUI TopSpeed;
    public string topspeed;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log((m_Rigidbody.velocity.magnitude * 2.23693629 ).ToString("0") + "THIS IS THE OPPONENT CAR SPEED");
        TopSpeed.GetComponent<TMP_Text>().text = "TopSpeed = " + topspeed;
        CurrentSpeed.GetComponent<TMP_Text>().text = "Speed = " + (m_Rigidbody.velocity.magnitude * 2.23693629 ).ToString("0") + "km/h";
    }
}
