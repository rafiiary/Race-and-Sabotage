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
    public InputField TurnAngleField;
    // Start is called before the first frame update
    void Start()
    {
        carController = Car.GetComponent<CarController>();
        SpeedField.onEndEdit.AddListener(delegate { LockInputSpeed(SpeedField); });
        DownforceField.onEndEdit.AddListener(delegate { LockInputDF(DownforceField); });
        TurnAngleField.onEndEdit.AddListener(delegate { LockInputTurnAngle(TurnAngleField); });
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LockInputSpeed(InputField field)
    {
        if (field.text.Length > 0)
        {
            Debug.Log("SOMETHING WAS JUST ENTERED SPEED");
            carController.m_Topspeed = float.Parse(field.text);
        }
        else
        {
            Debug.Log("NOTHING ENTERED BOYE");
        }
    }
    void LockInputDF(InputField field)
    {
        if (field.text.Length > 0)
        {
            Debug.Log("SOMETHING WAS JUST ENTERED DOWNFORCE");
            carController.m_Downforce = float.Parse(field.text);
        }
        else
        {
            Debug.Log("NOTHING ENTERED BOYE");
        }
    }
    void LockInputTurnAngle(InputField field)
    {
        if (field.text.Length > 0)
        {
            Debug.Log("SOMETHING WAS JUST ENTERED TURN ANGLE");
            float turn_angle = float.Parse(field.text);
            turn_angle = 20 + ((turn_angle % 20) / 10);
            carController.m_MaximumSteerAngle = turn_angle;
        }
        else
        {
            Debug.Log("NOTHING ENTERED BOYE");
        }
    }

}
