using UnityEngine;

public class VRSettingsMenu : MonoBehaviour
{
    [Header("Menu Panel")]
    public GameObject settingsMenu;   
    void Start()
    {
        // Hide menu at start
        if (settingsMenu != null)
            settingsMenu.SetActive(false);
    }

    // Called when clicking the Settings button
    public void OpenSettings()
    {
        if (settingsMenu != null)
            settingsMenu.SetActive(true);
    }

    // Called when clicking the X button
    public void CloseSettings()
    {
        if (settingsMenu != null)
            settingsMenu.SetActive(false);
    }
}