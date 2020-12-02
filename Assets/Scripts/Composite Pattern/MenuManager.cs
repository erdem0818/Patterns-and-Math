using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    MainMenu mainMenu = new MainMenu("MainMenu");
    MainMenu settings = new MainMenu("Settings");

    SubMenu credits = new SubMenu("Credits");

    //sub for settings
    SubMenu videoSettings = new SubMenu("VideoSettings");
    SubMenu audioSettings = new SubMenu("AudioSettings");

    private void Start() {
        mainMenu.Add(settings);
        mainMenu.Add(credits);

        settings.Add(videoSettings);
        settings.Add(audioSettings);

        mainMenu.OpenMenuBar();
        mainMenu.CloseMenuBar();
    }
}
