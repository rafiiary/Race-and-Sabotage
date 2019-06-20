using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

/* Behavior after finishing video of length length */
public class FinVidBehav : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    void Start()
    {
        videoPlayer.loopPointReached += loadScene;
    }
    void loadScene(VideoPlayer vp)
    {
        SceneManager.LoadScene("MainMenu");
    }
}
