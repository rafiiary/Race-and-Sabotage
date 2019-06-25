using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Change_terrain_chapter3 : MonoBehaviour
{
    public TextMeshProUGUI turn_right;
    public TextMeshProUGUI turn_left;
    public TextMeshProUGUI while_statement;
    public TextMeshProUGUI move_forward;
    public GameObject self;
    private bool entered_first_enumerate = false;
    private bool done1 = false;
    private bool done2 = true;
    public GameObject winCanvas;

    // Start is called before the first frame update
    void Start()
    {
        turn_right.color = new Color32(150, 20, 45, 45);
        turn_left.color = new Color32(150, 20, 45, 45);
        while_statement.color = new Color32(150, 20, 45, 45);
        move_forward.color = new Color32(150, 20, 45, 45);
    }

    // Update is called once per frame
    void Update()
    {
        if (winCanvas.active == true)
        {
            self.SetActive(false);
        }
        if (self.active == true)
        {
            if (!entered_first_enumerate)
            {
                StartCoroutine(RightAndLeft());
            }
            if (done1)
            {
                if (done2)
                {
                    StartCoroutine(while_execution());
                }
            }
        }
    }
    IEnumerator while_execution()
    {
        done2 = false;
        while_statement.color = new Color32(255, 128, 0, 255);
        move_forward.color = new Color32(150, 20, 45, 45);
        yield return new WaitForSeconds((float)0.5);
        move_forward.color = new Color32(255, 128, 0, 255);
        while_statement.color = new Color32(150, 20, 45, 45);
        yield return new WaitForSeconds((float)0.5);
        done2 = true;
    }
    IEnumerator RightAndLeft()
    {
        entered_first_enumerate = true;
        turn_right.color = new Color32(255, 128, 0, 255);
        yield return new WaitForSeconds((float)4);
        turn_left.color = new Color32(255, 128, 0, 255);
        turn_right.color = new Color32(150, 20, 45, 45);
        yield return new WaitForSeconds((float)1);
        turn_right.color = new Color32(150, 20, 45, 45);
        turn_left.color = new Color32(150, 20, 45, 45);
        done1 = true;
    }
    IEnumerator finishWhile(float time)
    {
        yield return new WaitForSeconds((float)time);
        self.SetActive(false);
    }
    void OnlyLightUPIf()
    {
        while_statement.color = new Color32(255, 128, 0, 255);
        move_forward.color = new Color32(150, 20, 45, 45);
    }
    void OnlyLightUPIfcontent()
    {
        move_forward.color = new Color32(255, 128, 0, 255);
        while_statement.color = new Color32(150, 20, 45, 45);
    }
}
