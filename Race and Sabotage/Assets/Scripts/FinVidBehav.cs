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
    float originalVolume;
    GameObject MusicPlayer;
    AudioSource theMusic;
    private void Start()
    {
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
            Debug.Log("Is Playing");
        }
        if (!videoPlayer.isPlaying)
        {
            Debug.Log("Finished playing");
            theMusic.volume = originalVolume;
            loadScene(videoPlayer);
        }   
    }

    void loadScene(VideoPlayer vp)
    {
        Debug.Log("Loading scene");
        SceneManager.LoadScene(LevelToLoad);
    }
}
