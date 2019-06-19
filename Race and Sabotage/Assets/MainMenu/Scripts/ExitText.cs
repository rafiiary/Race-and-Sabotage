using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ExitText : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
{
    public GameObject Exit;
    // Start is called before the first frame update
    void Start()
    {
        Exit.gameObject.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Exit.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Exit.gameObject.SetActive(false);
    }
}
