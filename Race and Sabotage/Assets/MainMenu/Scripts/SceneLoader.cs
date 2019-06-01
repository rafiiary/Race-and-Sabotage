using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    
    void loadGlossary()
    {
        SceneManager.LoadSceneAsync("Glossary");
    }
    /* Clear all previous chapters and start game from beginning */
    void newCampaign()
    {

    }
    /* View all the available chapters */
    void viewChapters()
    {
        
    }
    void exitGame()
    {
        Application.Quit();
    }
}
