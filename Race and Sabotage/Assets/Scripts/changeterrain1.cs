using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class changeterrain1 : MonoBehaviour
{
    public TextMeshProUGUI speed;
    public TextMeshProUGUI move_forward;
    private bool done = false;
    public GameObject car;
    public GameObject self;

    // Start is called before the first frame update
    void Start()
    {
        speed.color = new Color32(150, 20, 45, 45);
        move_forward.color = new Color32(150, 20, 45, 45);
    }

    // Update is called once per frame
    void Update()
    {
        if (car.active == true)
        {
            speed.color = new Color32(255, 128, 0, 255);
            StartCoroutine(Example());
            ////debug.log(done);
            if (done)
            {
                move_forward.color = new Color32(255, 128, 0, 255);
                speed.color = new Color32(150, 20, 45, 45);
            }
        }
        else
        {
            self.SetActive(false);
        }
    }
    IEnumerator Example()
    {
        yield return new WaitForSeconds((float)1);
        done = true;
    }
}
