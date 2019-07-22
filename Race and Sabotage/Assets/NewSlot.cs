using UnityEngine;
using System.Collections;
using System;
using UnityEngine.EventSystems;

public class NewSlot : MonoBehaviour, IDropHandler
{
    public static bool first, second, third, fourth, fifth = false;
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
        //Debug.Log(eventData.pointerDrag.name + " was dragged onto " + gameObject.name);
        string statement = eventData.pointerDrag.name + " " + gameObject.name;
        if (!item)
        {
            //transform.localScale += new Vector3(10F, 10f, 10f);
            DragandDrop.itemBeingDragged.transform.SetParent(transform);
            //transform.localScale += new Vector3(5F, 5f, 5f);
            //DragandDrop.itemBeingDragged.transform.SetPositionAndRotation(RectTransform, Quaternion.Euler(0, 0, 0));
            //ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject, null, (x, y) => x.HasChanged());

        }
        eventData.pointerDrag.GetComponent<RectTransform>().sizeDelta = new Vector2(gameObject.GetComponent<RectTransform>().sizeDelta.x, gameObject.GetComponent<RectTransform>().sizeDelta.y);
        eventData.pointerDrag.GetComponentInChildren<RectTransform>().sizeDelta = new Vector2(gameObject.GetComponent<RectTransform>().sizeDelta.x, gameObject.GetComponent<RectTransform>().sizeDelta.y); 
        SetBooleans(statement);
        //if (eventData.pointerDrag.tag == gameObject.tag)
        //{
        //    Debug.Log("WE REACHED HERE BOYS WOOOOOOOOOOO");
        //    switch (Int32.Parse(eventData.pointerDrag.tag))
        //    {
        //        case 1:
        //            first = true;
        //Debug.Log("first is " + first.ToString());
        //Debug.Log("second is " + second.ToString());
        //Debug.Log("third is " + third.ToString());
        //            break;
        //        case 2:
        //            second = true;
        //            Debug.Log("first is " + first.ToString());
        //            Debug.Log("second is " + second.ToString());
        //            Debug.Log("third is " + third.ToString());
        //            break;
        //        case 3:
        //            third = true;
        //            Debug.Log("first is " + first.ToString());
        //            Debug.Log("second is " + second.ToString());
        //            Debug.Log("third is " + third.ToString());
        //            break;
        //        default:
        //            first = false;
        //            second = false;
        //            third = false;
        //            Debug.Log("first is " + first.ToString());
        //            Debug.Log("second is " + second.ToString());
        //            Debug.Log("third is " + third.ToString());
        //            break;
        //    }
        //}
    }
    #endregion

    void SetBooleans(string statement)
    {
        switch (statement)
        {
            case "for destination1":
                first = true;
                break;
            case "obstacle destination2":
                second = true;
                break;
            case "obstacle_course destination3":
                third = true;
                break;
            case "climb_ramp destination4":
                fourth = true;
                break;
            case "follow_road destination5":
                fifth = true;
                break;
            default:
                first = false;
                second = false;
                third = false;
                fourth = false;
                fifth = false;
                break;
        }
    }
}
