using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCollect : MonoBehaviour
{
    private AudioSource audioSource;
    private Renderer objectRenderer;

    public int redCollected, orangeCollected, yellowCollected, greenCollected, blueCollected, purpleCollected, pinkCollected = 0;
    private string colorName;

    private List<IColorObserver> colorObservers = new List<IColorObserver>();

    public void CollectThisColor(string colorName) {
        if (colorName == "Red") {
            redCollected += 1;
        } else if (colorName == "Orange") {
            orangeCollected += 1;
        } else if (colorName == "Yellow") {
            yellowCollected += 1;
        } else if (colorName == "Green") {
            greenCollected += 1;
        } else if (colorName == "Blue") {
            blueCollected += 1;
        } else if (colorName == "Purple") {
            purpleCollected += 1;
        } else if (colorName == "Pink") {
            pinkCollected += 1;
        }

        foreach (var observer in colorObservers)
        {
            observer.UpdateColorCount(colorName, GetColorCount(colorName));
        }
    }

    public void AddObserver(IColorObserver observer)
    {
        colorObservers.Add(observer);
    }

    private int GetColorCount(string colorName)
    {
        int colorCount = 0;
        switch (colorName)
        {
            case "Red":
                colorCount = redCollected;
                break;
            case "Orange":
                colorCount = orangeCollected;
                break;
            case "Yellow":
                colorCount = yellowCollected;
                break;
            case "Green":
                colorCount = greenCollected;
                break;
            case "Blue":
                colorCount = blueCollected;
                break;
            case "Purple":
                colorCount = purpleCollected;
                break;
            case "Pink":
                colorCount = pinkCollected;
                break;
        }
        return colorCount;
    }
}
