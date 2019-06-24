using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablePauseMenu : MonoBehaviour
{
    public GameObject mainmenu;
    public GameObject PauseCanvas;
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void disableMenu()
    {
        mainmenu.SetActive(false);
    }
    public void returnSettings()
    {
        PauseCanvas.SetActive(true);
        menu.SetActive(true);
    }
}
