using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class changeTerrain2Right : MonoBehaviour
{
    public TextMeshProUGUI turn_right;
    public TextMeshProUGUI turn_left;
    public TextMeshProUGUI first_if;
    public TextMeshProUGUI second_if;
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
        if (other.tag == "DreamCar01")
        {
            turn_right.color = new Color32(255, 128, 0, 255);
            turn_left.color = new Color32(150, 20, 45, 45);
            first_if.color = new Color32(150, 20, 45, 45);
            second_if.color = new Color32(150, 20, 45, 45);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        turn_right.color = new Color32(150, 20, 45, 45);
        turn_left.color = new Color32(150, 20, 45, 45);
        first_if.color = new Color32(150, 20, 45, 45);
        second_if.color = new Color32(150, 20, 45, 45);
    }
}
