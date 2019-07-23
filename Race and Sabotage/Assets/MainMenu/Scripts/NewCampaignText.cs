using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewCampaignText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject NewCampaign;
    // Start is called before the first frame update
    void Start()
    {
        NewCampaign.gameObject.SetActive(false);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        NewCampaign.gameObject.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        NewCampaign.gameObject.SetActive(true);
    }

}
