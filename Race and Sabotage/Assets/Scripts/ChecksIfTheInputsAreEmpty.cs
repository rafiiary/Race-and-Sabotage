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
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(DropZone2.firstbox);
        if ((speedInput.text == "" || DownForceInput.text == "" || TurnAngle.text == ""))
        {
            Debug.Log("NO VARIABLESSSSSSSSSSSSSSSSSSSSSSSSSS");
            noInputs = true;
            ProceedButtonDAndD.otherscript = false;
            IncorrectMessage.text = "Input Variables";
        }
        else
        {
            IncorrectMessage.text = orignalMessageInIncorrectMessage;
        }
    }
}
