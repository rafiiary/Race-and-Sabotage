using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using TMPro;

public class DropBack : MonoBehaviour
{

    Vector3 newScale;
    string objectDroppedTag;
    public void Start()
    {
        newScale = new Vector3(1.8f, 0.75f);
        objectDroppedTag = "None";
    }
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


    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Item dropped");
        if (!item)
        {
            ItemDragHandler.itemBeingDragged.transform.SetParent(transform, false);
            ItemDragHandler.itemBeingDragged.transform.localScale = newScale;
        }
    }
}
