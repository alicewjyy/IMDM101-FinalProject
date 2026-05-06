using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalSceneSwitch : MonoBehaviour
{
    public string sceneName;
    
    private void OnTriggerEnter(Collider other)
    {            
        if (other.tag == "LevelExit")
        {
            Debug.Log(SceneManager.GetActiveScene().name);
            SceneManager.LoadScene(sceneName);
        }
    }
}
