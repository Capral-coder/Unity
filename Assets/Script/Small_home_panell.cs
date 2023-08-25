using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Small_home_panell : MonoBehaviour
{
    public GameObject Small_home_panel;

    void OnMouseUpAsButton()
    {
        int shop1 = PlayerPrefs.GetInt("shop1");
        int shop2 = PlayerPrefs.GetInt("shop2");
        int shop3 = PlayerPrefs.GetInt("shop3");
        int shop4 = PlayerPrefs.GetInt("shop4");
        int shop5 = PlayerPrefs.GetInt("shop5");
        int setting_open = PlayerPrefs.GetInt("setting_open");
        if (shop1 == 2  || shop2 == 2 || shop3 == 2 || shop4 == 2 || shop5 == 2 || setting_open == 2)
        {
            Debug.Log("Магазин открыт");
        }
        else
        {
            Small_home_panel.SetActive(true);
        }
    }
}
