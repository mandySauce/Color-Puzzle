using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCollectedColors : MonoBehaviour
{
    public ColorCollect cc;
    public Text redDisplay, orangeDisplay, yellowDisplay, greenDisplay, blueDisplay, purpleDisplay, pinkDisplay;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cc != null) {
            redDisplay.text = cc.redCollected.ToString();
            orangeDisplay.text = cc.orangeCollected.ToString();
            yellowDisplay.text = cc.yellowCollected.ToString();
            greenDisplay.text = cc.greenCollected.ToString();
            blueDisplay.text = cc.blueCollected.ToString();
            purpleDisplay.text = cc.purpleCollected.ToString();
            pinkDisplay.text = cc.pinkCollected.ToString();
        }
    }
}
