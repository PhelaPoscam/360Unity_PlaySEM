using UnityEngine;
using UnityEngine.Video;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(VideoPlayer))]
public class AudioDelayController : MonoBehaviour
{
    public float hastenMinus = 0.0f;
    public float delayPlus = 0.0f;
    
    private AudioSource audioSource;
    private VideoPlayer videoPlayer;
    
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        videoPlayer = GetComponent<VideoPlayer>();
    }
    
    void Start()
    {
        StartCoroutine(VideoStart());
    }

     IEnumerator VideoStart()
    {
        yield return new WaitForSeconds(1);
        audioSource.time += hastenMinus;
        videoPlayer.time += delayPlus;
        audioSource.Play();
        videoPlayer.Play();
    }
}