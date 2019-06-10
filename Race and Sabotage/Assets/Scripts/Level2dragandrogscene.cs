using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level2dragandrogscene : MonoBehaviour
{
    public GameObject drop1;
    private TextMeshPro m_Text;
    public GameObject drop2;
    public GameObject dragAndDropCanvas;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(drop1.transform.childCount >0 && drop2.transform.childCount > 0)
        {
            dragAndDropCanvas.SetActive(false);
            m_Text = drop1.transform.GetChild(0).GetChild(0).GetComponent<TextMeshPro>();
            Debug.Log(m_Text.text);

        }
        
    }
}
