using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SettingsText : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
{
    public GameObject Settings;
    // Start is called before the first frame update
    void Start()
    {
        Settings.gameObject.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Settings.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Settings.gameObject.SetActive(false);
    }
}
