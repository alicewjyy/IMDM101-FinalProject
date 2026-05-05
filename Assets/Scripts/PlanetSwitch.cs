using UnityEngine;
using UnityEngine.UI;

public class PlanetSwitch : MonoBehaviour
{
    [Header("planet (same position)")]
    public GameObject[] images;   // Drag your 3 image objects here

    private int currentIndex = 0;

    void Start()
    {
        ShowImage(currentIndex);
    }

    // Right Arrow Button
    public void NextImage()
    {
        currentIndex++;

        if (currentIndex >= images.Length)
            currentIndex = 0; // loops back to first

        ShowImage(currentIndex);
    }

    // Left Arrow Button
    public void PreviousImage()
    {
        currentIndex--;

        if (currentIndex < 0)
            currentIndex = images.Length - 1; // loops to last

        ShowImage(currentIndex);
    }

    void ShowImage(int index)
    {
        for (int i = 0; i < images.Length; i++)
        {
            images[i].SetActive(i == index);
        }
    }
}