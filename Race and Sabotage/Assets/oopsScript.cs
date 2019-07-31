using UnityEngine.SceneManagement;
using UnityEngine;

public class oopsScript : MonoBehaviour
{
    private static oopsScript instance = null;
    public static oopsScript Instance
    {
        get { return instance; }
    }
    /* Don't destroy this object between loads */
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("The oops buttons have been pressed");
            SceneManager.LoadScene("MainMenu");
        }
    }
}
