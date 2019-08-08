using UnityEngine;
using System.Collections;
using System;
using UnityEngine.EventSystems;

public class slot : MonoBehaviour, IDropHandler
{
    public static bool first, second, third = false;
    public GameObject item
    {
        get
        {
            if (transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }

    #region IDropHandler implementation
    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            //transform.localScale += new Vector3(10F, 10f, 10f);
            DragandDrop.itemBeingDragged.transform.SetParent(transform);            
            //transform.localScale += new Vector3(5F, 5f, 5f);
            //DragandDrop.itemBeingDragged.transform.SetPositionAndRotation(RectTransform, Quaternion.Euler(0, 0, 0));
            //ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject, null, (x, y) => x.HasChanged());

        }
        if (eventData.pointerDrag.tag == gameObject.tag)
        {
            ////debug.log("WE REACHED HERE BOYS WOOOOOOOOOOO");
            switch (Int32.Parse(eventData.pointerDrag.tag))
            {
                case 1:
                    first = true;
                    ////debug.log("first is " + first.ToString());
                    ////debug.log("second is " + second.ToString());
                    ////debug.log("third is " + third.ToString());
                    break;
                case 2:
                    second = true;
                    ////debug.log("first is " + first.ToString());
                    ////debug.log("second is " + second.ToString());
                    ////debug.log("third is " + third.ToString());
                    break;
                case 3:
                    third = true;
                    ////debug.log("first is " + first.ToString());
                    ////debug.log("second is " + second.ToString());
                    ////debug.log("third is " + third.ToString());
                    break;
                default:
                    first = false;
                    second = false;
                    third = false;
                    ////debug.log("first is " + first.ToString());
                    ////debug.log("second is " + second.ToString());
                    ////debug.log("third is " + third.ToString());
                    break;
            }
        }
        else
        {
            if (eventData.pointerDrag.tag == "1")
            {
                first = false;
            }
            if (eventData.pointerDrag.tag == "2")
            {
                second = false;
            }
            if (eventData.pointerDrag.tag == "3")
            {

                third = false;
            }
        }
    }
    #endregion
}
