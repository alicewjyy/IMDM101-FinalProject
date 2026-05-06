using UnityEngine;
using UnityEngine.UI;

public class AudioScrollbarController : MonoBehaviour
{
    [Header("Audio Sources")]
    public AudioSource backgroundMusic;
    public AudioSource sfxSource;

    [Header("UI Scrollbars / Sliders")]
    public Scrollbar musicScrollbar;
    public Scrollbar sfxScrollbar;

    void Start()
    {
        musicScrollbar.value = backgroundMusic.volume;
        sfxScrollbar.value = sfxSource.volume;

        musicScrollbar.onValueChanged.AddListener(ChangeMusicVolume);
        sfxScrollbar.onValueChanged.AddListener(ChangeSFXVolume);
    }

    public void ChangeMusicVolume(float value)
    {
        backgroundMusic.volume = value;
    }

    public void ChangeSFXVolume(float value)
    {
        sfxSource.volume = value;
    }

    public void PlayButtonSFX()
    {
        if (sfxSource != null)
            sfxSource.Play();
    }
}