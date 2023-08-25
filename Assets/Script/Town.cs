using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Town : MonoBehaviour
{
    public GameObject Game_panel, Panel_no_money, Panel_okey_buy, Snow;
    private int game_start;

    //public GameObject Game_Button, Exit_Button;

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
            Debug.Log(shop1);
            Debug.Log(shop2);
            Debug.Log(shop3);
            Debug.Log(shop4);
            Debug.Log(shop5);
        }
        else
        {
            Debug.Log(shop1);
            Game_panel.SetActive(true);
            Panel_no_money.SetActive(false);
            Panel_okey_buy.SetActive(false);
            game_start = 2;
            PlayerPrefs.SetInt("game_start", game_start);
            PlayerPrefs.Save();
            Snow.SetActive(false);
        }
    }

    public void CloseGame()
    {
        Game_panel.SetActive(false);
        Snow.SetActive(true);
        game_start = 0;
        PlayerPrefs.SetInt("game_start", game_start);
        PlayerPrefs.Save();
    }
}
