using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShowDescriptionText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text DescriptionText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        DescriptionText.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        DescriptionText.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        DescriptionText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
