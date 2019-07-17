using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using TMPro;

public class InventoryForLoop2 : MonoBehaviour, IDropHandler
{
    public int max_amount;
    public GameObject item
    {
        get
        {
            if (transform.childCount > max_amount)
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
            DragandDrop.itemBeingDragged.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color32(255, 128, 0, 255);
        }
    }
    #endregion
}
