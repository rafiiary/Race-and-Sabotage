using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropWithThree : MonoBehaviour
{
    public GameObject Choice1;
    public GameObject Choice2;
    public GameObject Choice3;
    public ProceedButtonDAndD proceed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Choice1.transform.parent.tag);
        Debug.Log(Choice1.transform.tag);
        if ((Choice1.transform.parent.tag == Choice1.transform.tag) & (Choice2.transform.parent.tag == Choice2.transform.tag) & (Choice3.transform.parent.tag == Choice3.transform.tag))
        {
            ProceedButtonDAndD.otherscript = true;
        }
        else
        {
            ProceedButtonDAndD.otherscript = false;
        }
    }
    IEnumerator WaitBeforeResettingDragAndDrop()
    {
        yield return new WaitForSeconds((float)10);
    }
}
