using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlossarySuggestion : MonoBehaviour
{
    public Button PauseButton;
    public Canvas GlossarySuggestionCanvas;
    private bool on = false;

    // Start is called before the first frame update
    void Start()
    {
        PauseButton.onClick.AddListener(ShowSuggestion);
    }

    // Update is called once per frame
    void Update()
    {
        if (on)
        {
            GlossarySuggestionCanvas.gameObject.SetActive(true);
        }
        else 
        {
            GlossarySuggestionCanvas.gameObject.SetActive(false);
        }
    }

    void ShowSuggestion()
    {
        on = !on;
    }
}
