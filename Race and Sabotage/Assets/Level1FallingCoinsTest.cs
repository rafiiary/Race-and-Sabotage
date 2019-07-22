using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1FallingCoinsTest : MonoBehaviour
{
    private bool entered = false;
    public GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isActiveAndEnabled & !entered)
        {
            entered = true;
            //debug.log("entered update");
            for (int i = 0; i<5; i++)
            {
                //debug.log("entered for loop");
                StartCoroutine(Example());
            }
        }
    }
    IEnumerator Example()
    {
        yield return new WaitForSeconds((float)1);
        Instantiate(coin, this.transform);
    }
}
