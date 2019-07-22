using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    //public bool droppable = true;

    public static bool firstbox, secondbox, thirdbox;

    public void OnDrop(PointerEventData eventData){

        if (this.transform.childCount > 0)
        {
            return;
        }
        string statement = eventData.pointerDrag.name + " was dropped on " + gameObject.name;
        SetTrue(statement);
        //debug.log(eventData.pointerDrag.name + " was dropped on " + gameObject.name);
        //debug.log("first box: " + firstbox.ToString());
        //debug.log("second box: " + secondbox.ToString());
        //debug.log("third box: " + thirdbox.ToString());

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null) // && droppable
        {
            d.PreferredParent = this.transform;
            //droppable = false;
        }

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //debug.log("OnPointerEnter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //debug.log("OnPointerExit");
    }

    void SetTrue(string statement)
    {
        switch (statement)
        {
            case "Choice2 was dropped on DestinationTop":
                secondbox = true;
                break;
            case "Choice1 was dropped on DestinationMiddle":
                firstbox = true;
                break;
            case "Choice3 was dropped on DestinationBottom":
                thirdbox = true;
                break;
            default:
                firstbox = false;
                secondbox = false;
                thirdbox = false;
                break;
        }
    }
}
