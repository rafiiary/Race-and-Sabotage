using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class turn_left : MonoBehaviour
{
    public TextMeshProUGUI turn_right;
    public TextMeshProUGUI turn_left2;
    public TextMeshProUGUI first_if;
    public TextMeshProUGUI second_if;
    public TextMeshProUGUI second_turn_right;
    public TextMeshProUGUI move_forward;
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
        print("before entering");
        print("entered dreamcar");
        turn_right.color = new Color32(150, 20, 45, 45);
        turn_left2.color = new Color32(255, 128, 0, 255);
        first_if.color = new Color32(150, 20, 45, 45);
        second_if.color = new Color32(150, 20, 45, 45);
        second_turn_right.color = new Color32(150, 20, 45, 45);
        move_forward.color = new Color32(150, 20, 45, 45);
    }
    private void OnTriggerExit(Collider other)
    {
        turn_right.color = new Color32(150, 20, 45, 45);
        turn_left2.color = new Color32(150, 20, 45, 45);
        first_if.color = new Color32(150, 20, 45, 45);
        second_if.color = new Color32(150, 20, 45, 45);
        second_turn_right.color = new Color32(150, 20, 45, 45);
        move_forward.color = new Color32(150, 20, 45, 45);
        Destroy(this);
    }
    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, 10))
            print("There is something in front of the object!");
    }
}
