using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Transform PreferredParent = null;
    public AudioSource speaker;
    public AudioClip dragSound;
    float volume = 1.0f;

    public void OnBeginDrag(PointerEventData eventData)
    {
        //debug.log("Begun dragging");
        speaker.PlayOneShot(dragSound, volume);
        //debug.log(this);
        PreferredParent = this.transform.parent;
        //debug.log("PREFERRED PARENT IS " + PreferredParent.ToString());
        //debug.log("PARENT will be set to " + this.transform.parent.parent.ToString());
        this.transform.SetParent(this.transform.parent.parent);

        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //debug.log("PLS DRAG PLS PLS");
        this.transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //debug.log("Ended dragging");
        speaker.PlayOneShot(dragSound, volume);
        this.transform.SetParent(PreferredParent);
        //debug.log("ON END OF DRAG, PARENT WILL BE " + PreferredParent.ToString());

        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
