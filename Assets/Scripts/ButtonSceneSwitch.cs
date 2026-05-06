using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonSceneSwitch : MonoBehaviour
{
    public string sceneName;
    public Button myButton;

    
    void Start()
    {
        Button btn = myButton.GetComponent<Button>();
        myButton.onClick.AddListener(SwitchScene);
    }
    public void SwitchScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
