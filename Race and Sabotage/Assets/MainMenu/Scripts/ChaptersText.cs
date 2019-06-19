using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChaptersText : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
{
    public GameObject Chapters;
    // Start is called before the first frame update
    void Start()
    {
        Chapters.gameObject.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Chapters.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Chapters.gameObject.SetActive(false);
    }
}
