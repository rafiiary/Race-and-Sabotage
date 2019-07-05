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
    public InputField TractionControl;
    // Start is called before the first frame update
    void Start()
    {
        carController = Car.GetComponent<CarController>();
        SpeedField.onEndEdit.AddListener(delegate { LockInputSpeed(SpeedField); });
        DownforceField.onEndEdit.AddListener(delegate { LockInputDF(DownforceField); });
        TractionControl.onEndEdit.AddListener(delegate { LockInputTraction(TractionControl); });
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
            //turn_angle = 20 + ((turn_angle % 20) / 10);
            carController.m_Downforce = float.Parse(field.text) % 10 + 100;
        }
        else
        {
            Debug.Log("NOTHING ENTERED BOYE");
        }
    }
    void LockInputTraction(InputField field)
    {
        if (field.text.Length > 0)
        {
            Debug.Log("SOMETHING WAS JUST ENTERED TURN ANGLE");
            float traction = float.Parse(field.text);
            if (traction > 1 || traction < 0)
            {
                carController.m_TractionControl = (float)0.5;
            }
            else
            {
                carController.m_TractionControl = traction;
            }
        }
        else
        {
            Debug.Log("NOTHING ENTERED BOYE");
        }
    }

}
