using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class slot : MonoBehaviour, IDropHandler
{
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
    }
    #endregion
}
