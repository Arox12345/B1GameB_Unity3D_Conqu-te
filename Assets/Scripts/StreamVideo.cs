using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class StreamVideo : MonoBehaviour
{
    public RawImage rawImage;
    public VideoPlayer videoPlayer;
    public AudioSource audioSource;
    public bool isImgOn;

    public Image ImageMenu01;
    // Use this for initialization
    void Start()
    {
        isImgOn = true;
    }

    public void LaunchVideo()
    {
        StartCoroutine(PlayVideo());
    }

    public void PauseVideo()
    {
        videoPlayer.Pause();
        audioSource.Pause();
    }

    public void ImageFadeY()
    {
        if (isImgOn == true)
        {

            ImageMenu01.enabled = false;
            isImgOn = false;
        }

        else
        {

            ImageMenu01.enabled = true;
            isImgOn = true;
        }
    }

    public void ImageFadeN()
    {
        ImageMenu01.enabled = false;
    }

    IEnumerator PlayVideo()
    {
        videoPlayer.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(0);
        while (!videoPlayer.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }
        rawImage.texture = videoPlayer.texture;
        videoPlayer.Play();
        audioSource.Play();
    }
}