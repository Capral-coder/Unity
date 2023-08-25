using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Debug : MonoBehaviour
{
    [SerializeField]
    GameObject Home_1_1_panel, 
    Home_1_2_panel, 
    Home_1_3_panel,
    Home_1_4_panel, 
    Home_1_5_panel, 
    Home_1_6_panel, 
    Home_1_7_panel, 
    Home_1_8_panel, 
    Home_1_9_panel,
    Home_1_10_panel, 
    Home_1_11_panel, 
    Home_1_12_panel,
    Home_2_1_panel, 
    Home_2_2_panel, 
    Home_2_3_panel,
    Home_2_4_panel, 
    Home_2_5_panel, 
    Home_2_6_panel, 
    Home_2_7_panel, 
    Home_2_8_panel, 
    Home_2_9_panel,
    Home_2_10_panel, 
    Home_2_11_panel, 
    Home_2_12_panel,
    Home_3_1_panel, 
    Home_3_2_panel, 
    Home_3_3_panel,
    Home_3_4_panel, 
    Home_3_5_panel, 
    Home_3_6_panel, 
    Home_3_7_panel, 
    Home_3_8_panel, 
    Home_3_9_panel,
    Home_3_10_panel, 
    Home_3_11_panel, 
    Home_3_12_panel;
    private int game_start;
    void Update()
    {
        int game_start_load = PlayerPrefs.GetInt("game_start");
        game_start = game_start_load;
        if (game_start == 2)
        {
            Debug.Log("Игра началась");
            Home_1_1_panel.SetActive(false);
            Home_1_2_panel.SetActive(false);
            Home_1_3_panel.SetActive(false);
            Home_1_4_panel.SetActive(false);
            Home_1_5_panel.SetActive(false);
            Home_1_6_panel.SetActive(false);
            Home_1_7_panel.SetActive(false);
            Home_1_8_panel.SetActive(false);
            Home_1_9_panel.SetActive(false);
            Home_1_10_panel.SetActive(false); 
            Home_1_11_panel.SetActive(false); 
            Home_1_12_panel.SetActive(false);
            Home_2_1_panel.SetActive(false); 
            Home_2_2_panel.SetActive(false); 
            Home_2_3_panel.SetActive(false);
            Home_2_4_panel.SetActive(false); 
            Home_2_5_panel.SetActive(false); 
            Home_2_6_panel.SetActive(false); 
            Home_2_7_panel.SetActive(false); 
            Home_2_8_panel.SetActive(false); 
            Home_2_9_panel.SetActive(false);
            Home_2_10_panel.SetActive(false); 
            Home_2_11_panel.SetActive(false); 
            Home_2_12_panel.SetActive(false);
            Home_3_1_panel.SetActive(false); 
            Home_3_2_panel.SetActive(false); 
            Home_3_3_panel.SetActive(false);
            Home_3_4_panel.SetActive(false); 
            Home_3_5_panel.SetActive(false); 
            Home_3_6_panel.SetActive(false); 
            Home_3_7_panel.SetActive(false); 
            Home_3_8_panel.SetActive(false); 
            Home_3_9_panel.SetActive(false);
            Home_3_10_panel.SetActive(false); 
            Home_3_11_panel.SetActive(false); 
            Home_3_12_panel.SetActive(false);
        }
    }
}
