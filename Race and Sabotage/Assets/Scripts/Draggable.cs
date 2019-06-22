﻿using System.Collections;
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
        Debug.Log("Begun dragging");
        speaker.PlayOneShot(dragSound, volume);
        PreferredParent = this.transform.parent;
        Debug.Log("PREFERRED PARENT IS " + PreferredParent.ToString());
        Debug.Log("PARENT will be set to " + this.transform.parent.parent.ToString());
        this.transform.SetParent(this.transform.parent.parent);

        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("PLS DRAG PLS PLS");
        this.transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Ended dragging");
        speaker.PlayOneShot(dragSound, volume);
        this.transform.SetParent(PreferredParent);
        Debug.Log("ON END OF DRAG, PARENT WILL BE " + PreferredParent.ToString());

        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
