using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GlossaryText : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
{
    public GameObject Glossary;
    // Start is called before the first frame update
    void Start()
    {
        Glossary.gameObject.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Glossary.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Glossary.gameObject.SetActive(false);
    }
}
