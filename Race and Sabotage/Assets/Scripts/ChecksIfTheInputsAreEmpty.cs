using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChecksIfTheInputsAreEmpty : MonoBehaviour
{
    public InputField speedInput;
    public InputField DownForceInput;
    public InputField TurnAngle;
    public Text IncorrectMessage;
    public static bool noInputs = false;
    private string orignalMessageInIncorrectMessage;
    // Start is called before the first frame update
    void Start()
    {
        orignalMessageInIncorrectMessage = IncorrectMessage.text;
        noInputs = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ((speedInput.text == "" || DownForceInput.text == "" || TurnAngle.text == ""))
        {
            noInputs = true;
            ProceedButtonDAndD.otherscript = false;
            IncorrectMessage.text = "Input Variables";
        }
        else
        {
            IncorrectMessage.text = orignalMessageInIncorrectMessage;
            noInputs = false;
        }
    }
}
