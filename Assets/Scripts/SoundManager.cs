using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] CanvasGroup youLostCanvasGroup;
    [SerializeField] AudioClip youLostClip; // You Lost AudioClip

    [SerializeField] CanvasGroup gameOverCanvasGroup;
    [SerializeField] AudioClip gameOverClip; // Game Over AudioClip

    [SerializeField] AudioClip backgroundClip; // Background AudioClip

    private AudioSource audioSource;
    private bool isMuted;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        PlaySound(backgroundClip); // Baþlangýçta arka plan müziðini çal
    }

    private void Update()
    {
        if (youLostCanvasGroup.alpha > 0)
        {
            PlaySound(youLostClip);
        }
        else if (gameOverCanvasGroup.alpha > 0)
        {
            PlaySound(gameOverClip);
        }
        else
        {
            PlaySound(backgroundClip);
        }
    }

    private void PlaySound(AudioClip clip)
    {
        if (audioSource.clip != clip)
        {
            audioSource.clip = clip;
            audioSource.Play();
        }
    }
}
