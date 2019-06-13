using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniGlossary : MonoBehaviour
{
    public Button MiniGlossaryButton;
    public Canvas MiniGlossaryCanvas;
    public Canvas PauseCanvas;
    // Start is called before the first frame update
    void Start()
    {
        MiniGlossaryButton.onClick.AddListener(EnableMiniGlossary);
        MiniGlossaryCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EnableMiniGlossary()
    {
        MiniGlossaryCanvas.gameObject.SetActive(true);
        PauseCanvas.gameObject.SetActive(false);
    }
}
