using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCollectedColors : MonoBehaviour, IColorObserver
{
    public ColorCollect cc;
    public Text redDisplay, orangeDisplay, yellowDisplay, greenDisplay, blueDisplay, purpleDisplay, pinkDisplay;
    
    // Start is called before the first frame update
    void Start()
    {
        if (cc != null)
        {
            cc.AddObserver(this);
        }
    }

    public void UpdateColorCount(string colorName, int count)
    {
        switch (colorName)
        {
            case "Red":
                redDisplay.text = count.ToString();
                break;
            case "Orange":
                orangeDisplay.text = count.ToString();
                break;
            case "Yellow":
                yellowDisplay.text = count.ToString();
                break;
            case "Green":
                greenDisplay.text = count.ToString();
                break;
            case "Blue":
                blueDisplay.text = count.ToString();
                break;
            case "Purple":
                purpleDisplay.text = count.ToString();
                break;
            case "Pink":
                pinkDisplay.text = count.ToString();
                break;
        }
    }
}
