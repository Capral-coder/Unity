using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Dosyagnenya : MonoBehaviour
{
    public Button button_Dos_1, button_Dos_2, button_Dos_3, button_Dos_4;
    private int otrumano_1, otrumano_2, otrumano_3, otrumano_4;
    public GameObject Panel_Dos, button_otrumano_1, button_otrumano_2, button_otrumano_3, button_otrumano_4;
    private int home_ok, small_home_ok;
    // Update is called once per frame
    void Update()
    {
        int Hospital_buy = PlayerPrefs.GetInt("Hospital_buy");
        int Police_buy = PlayerPrefs.GetInt("Police_buy");
        int Bank_buy = PlayerPrefs.GetInt("Bank_buy");
        int School_buy = PlayerPrefs.GetInt("School_buy");
        int Fire_station_buy = PlayerPrefs.GetInt("Fire_station_buy");

        int GYM_buy = PlayerPrefs.GetInt("GYM_buy");
        int GYM_buy_2 = PlayerPrefs.GetInt("GYM_buy_2");
        int ATB_buy = PlayerPrefs.GetInt("ATB_buy");
        int ATB_buy_2 = PlayerPrefs.GetInt("ATB_buy_2");
        int Bureger_buy = PlayerPrefs.GetInt("Bureger_buy");
        int Bureger_buy_2 = PlayerPrefs.GetInt("Bureger_buy_2");
        int Gas_station_buy = PlayerPrefs.GetInt("Gas_station_buy");
        int Gas_station_buy_2 = PlayerPrefs.GetInt("Gas_station_buy_2");
        int Shop_buy = PlayerPrefs.GetInt("Shop_buy");
        int Mac_buy = PlayerPrefs.GetInt("Mac_buy");
        int Cinema_buy = PlayerPrefs.GetInt("Cinema_buy");

        int Home_3_1_buy = PlayerPrefs.GetInt("Home_3_1_buy");
        int Home_3_2_buy = PlayerPrefs.GetInt("Home_3_2_buy");
        int Home_3_3_buy = PlayerPrefs.GetInt("Home_3_3_buy");
        int Home_3_4_buy = PlayerPrefs.GetInt("Home_3_4_buy");
        int Home_3_5_buy = PlayerPrefs.GetInt("Home_3_5_buy");
        int Home_3_6_buy = PlayerPrefs.GetInt("Home_3_6_buy");
        int Home_3_7_buy = PlayerPrefs.GetInt("Home_3_7_buy");
        int Home_3_8_buy = PlayerPrefs.GetInt("Home_3_8_buy");
        int Home_3_9_buy = PlayerPrefs.GetInt("Home_3_9_buy");

        int Small_home_3_1_buy = PlayerPrefs.GetInt("Small_home_3_1_buy");
        int Small_home_3_2_buy = PlayerPrefs.GetInt("Small_home_3_2_buy");
        int Small_home_3_3_buy = PlayerPrefs.GetInt("Small_home_3_3_buy");
        int Small_home_3_4_buy = PlayerPrefs.GetInt("Small_home_3_4_buy");
        int Small_home_3_5_buy = PlayerPrefs.GetInt("Small_home_3_5_buy");
        int Small_home_3_6_buy = PlayerPrefs.GetInt("Small_home_3_6_buy");
        int Small_home_3_7_buy = PlayerPrefs.GetInt("Small_home_3_7_buy");
        int Small_home_3_8_buy = PlayerPrefs.GetInt("Small_home_3_8_buy");
        int Small_home_3_9_buy = PlayerPrefs.GetInt("Small_home_3_9_buy");
        int Small_home_3_10_buy = PlayerPrefs.GetInt("Small_home_3_10_buy");
        int Small_home_3_11_buy = PlayerPrefs.GetInt("Small_home_3_11_buy");
        int Small_home_3_12_buy = PlayerPrefs.GetInt("Small_home_3_12_buy");

        int otrumano_2 = PlayerPrefs.GetInt("otrumano_2");
        int home_ok = PlayerPrefs.GetInt("home_ok");
        int small_home_ok = PlayerPrefs.GetInt("small_home_ok");

        int Game_point = PlayerPrefs.GetInt("Game_point");

//1

        if (Hospital_buy == 2 && Fire_station_buy == 2 && Police_buy == 2 && School_buy == 2 && Bank_buy == 2)
        {
            button_Dos_1.interactable = true;
        }
        else
        {
            button_Dos_1.interactable = false;
        }

        if (otrumano_1 == 2)
        {
            button_otrumano_1.SetActive(true);
        }

//2

        if (Home_3_1_buy == 2 || Home_3_2_buy == 2 || Home_3_3_buy == 2 || Home_3_4_buy == 2 || Home_3_5_buy == 2 || Home_3_6_buy == 2 || Home_3_7_buy == 2 ||
        Home_3_8_buy == 2 || Home_3_9_buy == 2)
        {
            home_ok = 2;
            PlayerPrefs.SetInt("home_ok", home_ok);
            PlayerPrefs.Save();       
        }

        if (Small_home_3_1_buy == 2 || Small_home_3_2_buy == 2 || Small_home_3_3_buy == 2 || Small_home_3_4_buy == 2 || Small_home_3_5_buy == 2 || 
        Small_home_3_6_buy == 2 || Small_home_3_7_buy == 2 || Small_home_3_8_buy == 2 || Small_home_3_9_buy == 2 || Small_home_3_10_buy == 2 || 
        Small_home_3_11_buy == 2 || Small_home_3_12_buy == 2)
        {
            small_home_ok = 2;
            PlayerPrefs.SetInt("small_home_ok", small_home_ok);
            PlayerPrefs.Save();  
        }

        if (home_ok == 2 && small_home_ok == 2)
        {
            button_Dos_2.interactable = true;
        }
        else
        {
            button_Dos_2.interactable = false;
        }

        if (otrumano_2 == 2)
        {
            button_otrumano_2.SetActive(true);
        }

//3

        if (GYM_buy == 2 && GYM_buy_2 == 2 && ATB_buy == 2 &&  ATB_buy_2 == 2 && Bureger_buy == 2 && Bureger_buy_2 == 2 &&
        Gas_station_buy == 2 && Gas_station_buy_2 == 2 &&Shop_buy == 2 && Mac_buy == 2 && Cinema_buy == 2)
        {
            button_Dos_3.interactable = true;
        }
        else
        {
            button_Dos_3.interactable = false;
        }

//4     
        
        if (Game_point == 100)
        {
            button_Dos_4.interactable = true;
        }
        else
        {
            button_Dos_4.interactable = false;
        }

    }
    public void BuyDos1()
    {
        int summ = PlayerPrefs.GetInt("summ");
        summ += 1000;
        PlayerPrefs.SetInt("summ", summ);
        otrumano_1 = 2;
        PlayerPrefs.SetInt("otrumano_1", otrumano_1);
        PlayerPrefs.Save();  
    }
    public void BuyDos2()
    {
        int summ = PlayerPrefs.GetInt("summ");
        summ += 1000;
        PlayerPrefs.SetInt("summ", summ);
        otrumano_2 = 2;
        PlayerPrefs.SetInt("otrumano_2", otrumano_2);
        PlayerPrefs.Save();  
    }

    public void BuyDos3()
    {
        int summ = PlayerPrefs.GetInt("summ");
        summ += 5000;
        PlayerPrefs.SetInt("summ", summ);
        otrumano_3 = 2;
        PlayerPrefs.SetInt("otrumano_3", otrumano_3);
        PlayerPrefs.Save();  
    }

    public void BuyDos4()
    {
        int summ = PlayerPrefs.GetInt("summ");
        summ += 800;
        PlayerPrefs.SetInt("summ", summ);
        otrumano_4 = 2;
        PlayerPrefs.SetInt("otrumano_4", otrumano_4);
        PlayerPrefs.Save();  
    }
    public void DosOpen()
    {
        Panel_Dos.SetActive(true);
    }
    public void DosClose()
    {
        Panel_Dos.SetActive(false);
    }

}
