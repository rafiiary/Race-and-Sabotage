using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManageSurenessPanels : MonoBehaviour
{
    public GameObject StarterPanel;
    public GameObject GlossaryPanel;
    public GameObject SettingsPanel;
    // Start is called before the first frame update
    void Start()
    {
        GlossaryPanel.gameObject.SetActive(false);
        SettingsPanel.gameObject.SetActive(false);
        StarterPanel.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowGlossaryPanel()
    {
        StarterPanel.gameObject.SetActive(false);
        GlossaryPanel.gameObject.SetActive(true);
        SettingsPanel.gameObject.SetActive(false);
    }

    public void GoToScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void HideGlossaryPanel()
    {
        GlossaryPanel.gameObject.SetActive(false);
        StarterPanel.gameObject.SetActive(true);
        SettingsPanel.gameObject.SetActive(false);
    }

    public void ShowSettingsPanel()
    {
        StarterPanel.gameObject.SetActive(false);
        GlossaryPanel.gameObject.SetActive(false);
        SettingsPanel.gameObject.SetActive(true);
    }

    public void HideSettingsPanel()
    {
        SettingsPanel.gameObject.SetActive(false);
        GlossaryPanel.gameObject.SetActive(false);
        StarterPanel.gameObject.SetActive(true);
    }
}
