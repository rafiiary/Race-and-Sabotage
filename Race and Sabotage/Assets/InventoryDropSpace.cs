using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using TMPro;

public class InventoryDropSpace : MonoBehaviour, IDropHandler
{

    Vector3 newScale;
    string objectDroppedTag;
    public int maxInventoryNumber = 1;
    public void Start()
    {
        newScale = new Vector3(1f, 1f);
        objectDroppedTag = "None";
    }
    public GameObject itemx
    {
        get
        {
            if (transform.childCount > (maxInventoryNumber - 1))
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }


    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Item dropped");
        ItemDragHandler.itemBeingDragged.transform.SetParent(transform, false);
        ItemDragHandler.itemBeingDragged.transform.localScale = DropSpace.originalTimeScale;
        gameObject.GetComponent<correctPanelOn>().updateSolved();
    }
}
