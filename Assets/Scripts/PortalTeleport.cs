using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneTeleport : MonoBehaviour
{
    public string sceneToLoad;
    public AudioSource playAudio;
    public AudioClip collisionSound;
    public float delay = 1.5f;
    private bool isTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the XR Rig entered the trigger
        if (other.CompareTag("Player") && !isTriggered)
        {
            isTriggered = true;
            StartCoroutine(PlayThenLoad());
        }
    }

    private IEnumerator PlayThenLoad()
    {
        playAudio.PlayOneShot(collisionSound);
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneToLoad);
    }
}