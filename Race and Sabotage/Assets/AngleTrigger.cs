using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleTrigger : MonoBehaviour
{
    public GameObject DragAndDropAngle;
    public GameObject drop2;
    public GameObject car;
    public bool entered_once = false;
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
        if (!entered_once)
        {
            entered_once = true;
            DragAndDropAngle.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
