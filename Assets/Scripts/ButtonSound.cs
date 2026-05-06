using UnityEngine;

public class UIButtonSound : MonoBehaviour
{
    [Header("Sound")]
    public AudioSource audioSource;
    public AudioClip buttonClickSound;

    public void PlayButtonSound()
    {
        if (audioSource != null && buttonClickSound != null)
        {
            audioSource.PlayOneShot(buttonClickSound);
        }
    }
}