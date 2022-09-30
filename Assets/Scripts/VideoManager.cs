using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System.IO;

public class VideoManager : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public string Url;
    string rootPath;
    string path;

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

    public void Awake() 
    {
        //videoClip.originalPath = path;
        videoPlayer.source = VideoSource.Url;
        rootPath = Application.persistentDataPath;
        path = Path.Combine(rootPath, Url);
        videoPlayer.url = path;
        videoPlayer.Prepare();
        if (videoPlayer.isPrepared) {
            Play();
        }

        
    }

    
}
