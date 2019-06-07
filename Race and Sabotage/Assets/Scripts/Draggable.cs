using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Transform PreferredParent = null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("Begun dragging");
        PreferredParent = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);

        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("PLS DRAG PLS PLS");
        this.transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("Ended dragging");
        this.transform.SetParent(PreferredParent);

        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
