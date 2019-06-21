using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LightUpTurnables : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Color clickedColor;
    Color originalColor;
    public GameObject panel;
    void Start()
    {
        originalColor = panel.GetComponent<Image>().color;
        clickedColor = new Color(255f, 255f, 0f);
        clickedColor.a = 0.5f;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        panel.GetComponent<Image>().color = clickedColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        panel.GetComponent<Image>().color = originalColor;
    }
}
