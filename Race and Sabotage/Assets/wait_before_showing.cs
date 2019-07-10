using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wait_before_showing : MonoBehaviour
{
    public GameObject mousehover;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds((float)3);
        mousehover.SetActive(true);
    }
}
