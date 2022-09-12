using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{

    private VideoPlayer videoPlayer;

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

    public void URLToVideo(string url) 
    {
        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = "https://unity-youtube-dl-server.herokuapp.com/watch?v=dQw4w9WgXcQ";
        videoPlayer.Prepare();
        if (videoPlayer.isPrepared) {
            Play();
        }

        
    }

    /*private void VideoPlayer_prepareCompleted(VideoPlayer source) {
        Play();
    }*/
    
}
