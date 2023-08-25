using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Tutorial : MonoBehaviour
{
    private int tutorial;
    private int tutorial2;
    private int tutorial3;
    private int location;
    private int camera;
    public Button Shop, Settings;
    public GameObject tutorial_1_panel, tutorial_2_panel, shop_button, settings_button;
    // Start is called before the first frame update
    void Update()
    {
        int tutorialload = PlayerPrefs.GetInt("tutorial");
        tutorial = tutorialload;
        if (tutorial == 2)
        {
            Shop.interactable = false;
            Settings.interactable = false;
            tutorial_1_panel.SetActive(true);
        }

        if (tutorial2 == 2)
        {
            tutorial_2_panel.SetActive(true);
            Settings.interactable = false;
        }
        else
        {
            Settings.interactable = true;
        }

    }
    public void Tutorial1Close()
    {
        shop_button.SetActive(false);
        tutorial_1_panel.SetActive(false);
        tutorial = 0;
        PlayerPrefs.SetInt("tutorial", tutorial);
        tutorial2 = 2;
        Shop.interactable = true;
        Settings.interactable = true;
        location = 2;
        PlayerPrefs.SetInt("location", location);
        PlayerPrefs.Save();
    }

    public void Tutorial2Close()
    {
        shop_button.SetActive(true);
        tutorial_2_panel.SetActive(false);
        tutorial2 = 0;
        camera = 0;
        PlayerPrefs.SetInt("camera", camera);
        location = 0;
        PlayerPrefs.SetInt("location", location);
        PlayerPrefs.Save();
    }

}

// -40 885 18
// 331 885 209