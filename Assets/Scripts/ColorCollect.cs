using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCollect : MonoBehaviour
{
    private AudioSource audioSource;
    private Renderer objectRenderer;

    public int redCollected, orangeCollected, yellowCollected, greenCollected, blueCollected, purpleCollected, pinkCollected = 0;
    private string colorName;

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
    }
}
