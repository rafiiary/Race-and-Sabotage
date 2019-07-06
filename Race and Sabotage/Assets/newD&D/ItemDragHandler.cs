using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ItemDragHandler : MonoBehaviour,IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject itemBeingDragged;
    Vector3 startPosition;
    Transform startParent;
    Component[] tmTexts;
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Began dragging");
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        tmTexts = itemBeingDragged.GetComponentsInChildren<TMP_Text>();
        tmTexts[0].GetComponent<TMP_Text>().fontSize = 10.65f;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Ended dragging");
        itemBeingDragged = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if(transform.parent == startParent)
        {
            transform.position = startPosition;
        }
    }
}
