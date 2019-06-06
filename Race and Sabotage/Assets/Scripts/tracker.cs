using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class tracker : MonoBehaviour
{

    public GameObject TheMarker;
    public GameObject Mark01;
    public GameObject Mark02;
    public GameObject Mark03;
    public GameObject Mark04;
    public GameObject Mark05;
    public GameObject Mark06;
    public GameObject Mark07;
    public GameObject Mark08;
    public int MarkTracker;

    void Update()
    {
        switch (MarkTracker)
        {
            case 0:
                TheMarker.transform.position = Mark01.transform.position;
                break;
            case 1:
                TheMarker.transform.position = Mark02.transform.position;
                break;
            case 2:
                TheMarker.transform.position = Mark03.transform.position;
                break;
            case 3:
                TheMarker.transform.position = Mark04.transform.position;
                break;
            case 4:
                TheMarker.transform.position = Mark05.transform.position;
                break;
            case 5:
                TheMarker.transform.position = Mark06.transform.position;
                break;
            case 6:
                TheMarker.transform.position = Mark07.transform.position;
                break;
            case 7:
                TheMarker.transform.position = Mark08.transform.position;
                break;
            //default:
            //TheMarker.transform.position = Mark01.transform.position;
            //break;
            default:
                Destroy(TheMarker);
                break;
        }
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Dreamcar01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker += 1;
           
            print(MarkTracker);
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
