using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] CanvasGroup youLostCanvasGroup;
    [SerializeField] CanvasGroup gameOverCanvasGroup;

    private AudioSource backgroundAudioSource;
    private bool isMuted;

    private void Awake()
    { 
        backgroundAudioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (youLostCanvasGroup.alpha > 0 || gameOverCanvasGroup.alpha > 0)
        {
            StopBackgroundSound();
        }
        else 
        {
            PlayBackgroundSound();
        }
    }

    private void PlayBackgroundSound()
    {
        if (isMuted && !backgroundAudioSource.isPlaying)
        {
            isMuted = false;
            backgroundAudioSource.Play();
        }
    }

    private void StopBackgroundSound()
    {
        if (!isMuted && backgroundAudioSource.isPlaying)
        {
            isMuted = true;
            backgroundAudioSource.Stop();
        }
    }
}
