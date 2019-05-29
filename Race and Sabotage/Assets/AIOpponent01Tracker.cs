using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIOpponent01Tracker : MonoBehaviour
{
    public GameObject TheMarker;
    public GameObject Marker;
    public GameObject Marker1;
    public GameObject Marker2;
    public GameObject Marker3;
    public GameObject Marker4;
    public GameObject Marker5;
    public GameObject Marker6;
    public GameObject Marker7;
    public int MarkTracker;

    void Update()
    {
        switch (MarkTracker)
        {
            case 0:
                TheMarker.transform.position = Marker.transform.position;
                break;
            case 1:
                TheMarker.transform.position = Marker1.transform.position;
                break;
            case 2:
                TheMarker.transform.position = Marker2.transform.position;
                break;
            case 3:
                TheMarker.transform.position = Marker3.transform.position;
                break;
            case 4:
                TheMarker.transform.position = Marker4.transform.position;
                break;
            case 5:
                TheMarker.transform.position = Marker5.transform.position;
                break;
            case 6:
                TheMarker.transform.position = Marker6.transform.position;
                break;
            case 7:
                TheMarker.transform.position = Marker7.transform.position;
                break;
            default:
                TheMarker.transform.position = Marker.transform.position;
                break;
        }
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        Debug.Log("Y U NO WORK?!?!");
        if (collision.gameObject.tag == "simpletag")
        {
            Debug.Log("PLS WORK");
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker += 1;
            if (MarkTracker == 8)
            {
                MarkTracker = 0;
            }
        }
        yield return new WaitForSeconds(1);
        this.GetComponent<BoxCollider>().enabled = true;
    }


}
