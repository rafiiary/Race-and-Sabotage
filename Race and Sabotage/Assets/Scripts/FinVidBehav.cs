using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

/* Behavior after finishing video of length length */
public class FinVidBehav : MonoBehaviour
{
    public string LevelToLoad;
    public VideoPlayer videoPlayer;

    private void Start()
    {
        
        videoPlayer.Play();
    }
    private void Update()
    {
        if (videoPlayer.isPlaying)
        {
            Debug.Log("Is Playing");
        }
        if (!videoPlayer.isPlaying)
        {
            Debug.Log("Finished playing");
            loadScene(videoPlayer);
        }   
    }

    void loadScene(VideoPlayer vp)
    {
        Debug.Log("Loading scene");
        SceneManager.LoadScene(LevelToLoad);
    }
}
