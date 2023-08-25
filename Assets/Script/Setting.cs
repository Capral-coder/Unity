using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    private int setting_open;

    public GameObject Setting_panel, Panel_no_money, Panel_okey_buy, Snow;
    void Update()
    {
        int shop1 = PlayerPrefs.GetInt("shop1");
        int shop2 = PlayerPrefs.GetInt("shop2");
        int shop3 = PlayerPrefs.GetInt("shop3");
        int shop4 = PlayerPrefs.GetInt("shop4");
        int shop5 = PlayerPrefs.GetInt("shop5");
        if (shop1 == 2  || shop2 == 2 || shop3 == 2 || shop4 == 2 || shop5 == 2)
        {
            Setting_panel.SetActive(false);
        }
    }

    public void SettingOpen()
    {
        int shop1 = PlayerPrefs.GetInt("shop1");
        int shop2 = PlayerPrefs.GetInt("shop2");
        int shop3 = PlayerPrefs.GetInt("shop3");
        int shop4 = PlayerPrefs.GetInt("shop4");
        int shop5 = PlayerPrefs.GetInt("shop5");
        if (shop1 == 2  || shop2 == 2 || shop3 == 2 || shop4 == 2 || shop5 == 2)
        {
            Debug.Log("Магазин открыт");
        }
        else
        {
            Snow.SetActive(false);
            Setting_panel.SetActive(true);
            Panel_no_money.SetActive(false);
            Panel_okey_buy.SetActive(false);
            setting_open = 2;
            PlayerPrefs.SetInt("setting_open", setting_open);
            PlayerPrefs.Save();
        }
        
    }

    public void SettingClose()
    {
        Setting_panel.SetActive(false);
        setting_open = 0;
        PlayerPrefs.SetInt("setting_open", setting_open);
        PlayerPrefs.Save();
        Snow.SetActive(true);
    }

    public void SupportOpen()
    {
        Application.OpenURL("https://ssp-company.ml/contacts.html");
    }

    public void AboutOpen()
    {
        Application.OpenURL("https://ssp-company.ml/about.html");
    }

    public void PolicyOpen()
    {
        Application.OpenURL("https://ssp-company.ml/privacy_policy.html");
    }
}
