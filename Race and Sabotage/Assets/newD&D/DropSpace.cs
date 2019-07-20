using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using TMPro;

public class DropSpace : MonoBehaviour, IDropHandler
{

    Vector3 newScale;
    string objectDroppedTag;
    public static Vector3 originalTimeScale;
    private float OriginalFontSize;
    public static bool began = false;
    public void Start()
    {
        newScale = new Vector3(1.8f, 0.75f);
        objectDroppedTag = "None";
        began = false;
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
            began = true;
            ItemDragHandler.itemBeingDragged.transform.SetParent(transform, false);
            originalTimeScale = ItemDragHandler.itemBeingDragged.transform.localScale;
            ItemDragHandler.itemBeingDragged.transform.localScale = newScale;
            gameObject.GetComponent<correctPanelOn>().updateSolved();
        }
    }
}
