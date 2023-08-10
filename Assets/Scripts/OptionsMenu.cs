using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public GameObject settingsMenu;

    public void OpenSettingsMenu() {
        settingsMenu.SetActive(true);
    }

    public void CloseSettingsMenu() {
        settingsMenu.SetActive(false);
    }

    void Update(){

    }
}