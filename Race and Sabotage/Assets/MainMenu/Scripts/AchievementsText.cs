using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AchievementsText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject Achievements;
    // Start is called before the first frame update
    void Start()
    {
        Achievements.gameObject.SetActive(false);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Achievements.gameObject.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Achievements.gameObject.SetActive(true);
    }



}
