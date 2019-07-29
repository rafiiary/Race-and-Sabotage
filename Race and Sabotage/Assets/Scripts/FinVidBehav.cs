using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

/* Behavior after finishing video of length length */
[RequireComponent(typeof(SceneArray))]
public class FinVidBehav : MonoBehaviour
{
    public string LevelToLoad;
    public VideoPlayer videoPlayer;
    SceneArray sceneArray;
    float originalVolume;
    GameObject MusicPlayer;
    AudioSource theMusic;
    private void Start()
    {
        sceneArray = GetComponent<SceneArray>();
        MusicPlayer = GameObject.FindGameObjectWithTag("Speaker");
        if (MusicPlayer != null)
        {
            theMusic = MusicPlayer.GetComponent<AudioSource>();
            originalVolume = theMusic.volume;
            if (theMusic.volume > 0.25f)
            {
                theMusic.volume = 0.25f;
            }
        }
        videoPlayer.Play();
    }
    private void Update()
    {
        if (videoPlayer.isPlaying)
        {
            ////debug.log("Is Playing");
        }
        if (!videoPlayer.isPlaying)
        {
            ////debug.log("Finished playing");
            if (theMusic != null)
            {
                theMusic.volume = originalVolume;
            }
            sceneArray.NextScene();
            //loadScene(videoPlayer);
        }   
    }

    void loadScene(VideoPlayer vp)
    {
        ////debug.log("Loading scene");
        SceneManager.LoadScene(LevelToLoad);
    }
}
