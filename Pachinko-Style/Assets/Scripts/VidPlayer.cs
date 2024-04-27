using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VidPlayer : MonoBehaviour
{
    [SerializeField] private string videoURL = "https://drive.google.com/file/d/13a1IIgtfEEefEz0tlv4_t0IzZJqp-zl1/view?usp=drive_link";
    private VideoPlayer videoPlayer;
    // Start is called before the first frame update

    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        if(videoPlayer)
        { 
            videoPlayer.url = videoURL;
            videoPlayer.playOnAwake = false;
            videoPlayer.Prepare();

            videoPlayer.prepareCompleted += OnVideoPrepared;
        
        }
    }

    // Update is called once per frame
    private void OnVideoPrepared(VideoPlayer source)
    {
        videoPlayer.Play();
    }
}
