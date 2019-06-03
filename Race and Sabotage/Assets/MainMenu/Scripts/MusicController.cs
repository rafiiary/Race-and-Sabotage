using System.Collections.Generic;
using UnityEngine;

[System.Serializable] public class MusicController : MonoBehaviour
{
    int sizeOfList = 5;

    int currPlayingIndex;
    //Random number to choose which song to play
    int randomNumber;
    //True iff next song has been requested;
    bool nextSongRequest;
    public AudioSource theSpeaker;
    public List<AudioClip> PlayList = new List<AudioClip>();

    /* Generate random song to play at the start of the game */
    void Start()
    {
        nextSongRequest = false;
        randomNumber = Random.Range(0, sizeOfList);
        currPlayingIndex = randomNumber;
        theSpeaker.PlayOneShot(PlayList[randomNumber]);
    }

    /* Play another song */
    public void nextSong()
    {
        nextSongRequest = true;
        theSpeaker.Stop();
        while (randomNumber == currPlayingIndex)
        {
            randomNumber = Random.Range(0, sizeOfList);
        }
        currPlayingIndex = randomNumber;
        theSpeaker.PlayOneShot(PlayList[randomNumber]);
        nextSongRequest = false;
    }

    /* Keep checking to see if current song is over. If yes, then generate NEW random
     * song and play that instead. Else, do nothing. */
    void Update()
    {
        if (!theSpeaker.isPlaying && !nextSongRequest)
        {
            while(randomNumber == currPlayingIndex)
            {
                randomNumber = Random.Range(0, sizeOfList);
            }
            currPlayingIndex = randomNumber;
            theSpeaker.PlayOneShot(PlayList[randomNumber]);
        }
    }
}
