using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{

    private VideoPlayer videoPlayer;
    private VideoClip videoClip;

    private void Start() 
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    public void Play() 
    {
        videoPlayer.Play();
    }

    public void Pause() 
    {
        videoPlayer.Pause();
    }

    public void Stop() 
    {
        videoPlayer.Stop();

    }

    public void LoadClip(string path) 
    {
        //videoClip.originalPath = path;
        videoPlayer.source = VideoSource.VideoClip;
        videoPlayer.Prepare();
        if (videoPlayer.isPrepared) {
            Play();
        }

        
    }

    
}
