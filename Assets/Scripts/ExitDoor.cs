using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour
{
    public ColorCollect cc;

    public int redNeeded, orangeNeeded, yellowNeeded, greenNeeded, blueNeeded, purpleNeeded, pinkNeeded;
    private bool redSatisfied, orangeSatisfied, yellowSatisfied, greenSatisfied, blueSatisfied, purpleSatisfied, pinkSatisfied = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool CheckPlayerColors() {
        if(cc.redCollected >= redNeeded) {
            redSatisfied = true;
        }
        if(cc.orangeCollected >= orangeNeeded) {
            orangeSatisfied = true;
        }

        if(cc.yellowCollected >= yellowNeeded) {
            yellowSatisfied = true;
        }

        if(cc.greenCollected >= greenNeeded) {
            greenSatisfied = true;
        }

        if(cc.blueCollected >= blueNeeded) {
            blueSatisfied = true;
        }

        if(cc.purpleCollected >= purpleNeeded) {
            purpleSatisfied = true;
        }

        if(cc.pinkCollected >= pinkNeeded) {
            pinkSatisfied = true;
        }

        return redSatisfied && orangeSatisfied && yellowSatisfied && greenSatisfied && blueSatisfied && purpleSatisfied && pinkSatisfied;

    }

    public void AttemptToOpenExitDoor() {
        bool canOpenExitDoor = CheckPlayerColors();

        if (canOpenExitDoor) {
            NextLevel();
        }
    }

    public void NextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
