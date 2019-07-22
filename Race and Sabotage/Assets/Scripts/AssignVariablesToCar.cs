using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class AssignVariablesToCar : MonoBehaviour
{
    public GameObject Car;
    private CarController carController;
    public InputField SpeedField;
    public InputField DownforceField;
    public InputField TurnAngle;
    // Start is called before the first frame update
    void Start()
    {
        carController = Car.GetComponent<CarController>();
        SpeedField.onEndEdit.AddListener(delegate { LockInputSpeed(SpeedField); });
        DownforceField.onEndEdit.AddListener(delegate { LockInputDF(DownforceField); });
        TurnAngle.onEndEdit.AddListener(delegate {LockInputTurnAngle(TurnAngle); });
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LockInputSpeed(InputField field)
    {
        if (field.text.Length > 0)
        {
            //debug.log("SOMETHING WAS JUST ENTERED SPEED");
            carController.m_Topspeed = float.Parse(field.text);
        }
        else
        {
            //debug.log("NOTHING ENTERED BOYE");
        }
    }
    void LockInputDF(InputField field)
    {
        if (field.text.Length > 0)
        {
            //debug.log("SOMETHING WAS JUST ENTERED DOWNFORCE");
            //turn_angle = 20 + ((turn_angle % 20) / 10);
            carController.m_Downforce = float.Parse(field.text) % 10 + 100;
        }
        else
        {
            //debug.log("NOTHING ENTERED BOYE");
        }
    }

    void LockInputTurnAngle(InputField field)
    {
        //debug.log("WE REACHED HERE INSIDE THE TURN ANGLE FUNCTION");
        if (field.text.Length > 0)
        {
            float turnAngle = float.Parse(field.text);
            turnAngle = 19 + ((turnAngle % 20) / 10);
            //debug.log("TURN ANGLE WAS FOUND TO BE " + turnAngle.ToString());
            carController.m_MaximumSteerAngle = turnAngle;
        }
    }

}
