using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Sale : MonoBehaviour
{   
    private int Home_1_1_buy;
    private int Home_1_2_buy;
    private int Home_1_3_buy;
    private int Home_1_4_buy;
    private int Home_1_5_buy;
    private int Home_1_6_buy;
    private int Home_1_7_buy;
    private int Home_1_8_buy;
    private int Home_1_9_buy;
    private int Home_2_1_buy;
    private int Home_2_2_buy;
    private int Home_2_3_buy;
    private int Home_2_4_buy;
    private int Home_2_5_buy;
    private int Home_2_6_buy;
    private int Home_2_7_buy;
    private int Home_2_8_buy;
    private int Home_2_9_buy;
    private int Home_3_1_buy;
    private int Home_3_2_buy;
    private int Home_3_3_buy;
    private int Home_3_4_buy;
    private int Home_3_5_buy;
    private int Home_3_6_buy;
    private int Home_3_7_buy;
    private int Home_3_8_buy;
    private int Home_3_9_buy;

    private float time = 60;
    private string nameprice;
    private int price;
    private string userid;
    private string loadusers;
    private int shop1;
    private int shop2;
    private int shop3;
    private int shop4;
    private int shop5;
    private int game_start;

    [SerializeField]
    GameObject  Home_1_1_prefab,
    Home_1_2_prefab,
    Home_1_3_prefab,
    Home_1_4_prefab,
    Home_1_5_prefab,
    Home_1_6_prefab,
    Home_1_7_prefab,
    Home_1_8_prefab,
    Home_1_9_prefab,
    Home_2_1_prefab,
    Home_2_2_prefab,
    Home_2_3_prefab,
    Home_2_4_prefab,
    Home_2_5_prefab,
    Home_2_6_prefab,
    Home_2_7_prefab,
    Home_2_8_prefab,
    Home_2_9_prefab,
    Home_3_1_prefab,
    Home_3_2_prefab,
    Home_3_3_prefab,
    Home_3_4_prefab,
    Home_3_5_prefab,
    Home_3_6_prefab,
    Home_3_7_prefab,
    Home_3_8_prefab,
    Home_3_9_prefab;

    [SerializeField]
    GameObject Button_Home_1_1_buy_1, 
    Button_Home_1_2_buy_1, 
    Button_Home_1_3_buy_1, 
    Button_Home_1_4_buy_1, 
    Button_Home_1_5_buy_1, 
    Button_Home_1_6_buy_1, 
    Button_Home_1_7_buy_1, 
    Button_Home_1_8_buy_1,  
    Button_Home_1_9_buy_1, Button_Home_1_9_buy_2;

    [SerializeField]
    GameObject ButStore,ButStore2,ButStore3, ButStore4, ButStore5, panelBox, sales, 
    Home_1_1_panel, 
    Home_1_2_panel, 
    Home_1_3_panel,
    Home_1_4_panel, 
    Home_1_5_panel, 
    Home_1_6_panel, 
    Home_1_7_panel, 
    Home_1_8_panel, 
    Home_1_9_panel,
    Home_2_1_panel, 
    Home_2_2_panel, 
    Home_2_3_panel,
    Home_2_4_panel, 
    Home_2_5_panel, 
    Home_2_6_panel, 
    Home_2_7_panel, 
    Home_2_8_panel, 
    Home_2_9_panel,
    Home_3_1_panel, 
    Home_3_2_panel, 
    Home_3_3_panel,
    Home_3_4_panel, 
    Home_3_5_panel, 
    Home_3_6_panel, 
    Home_3_7_panel, 
    Home_3_8_panel, 
    Home_3_9_panel;
    
    public string nameBuy;
    public int summ;
    public Text textSum;
    public GameObject Panel_no_money, Panel_okey_buy;


    void Start()
    {
        //summ;
        int summ = PlayerPrefs.GetInt("summ");
        textSum.text = summ.ToString();
        ButStore.SetActive(false);
        ButStore2.SetActive(false);
        ButStore3.SetActive(false);
        ButStore4.SetActive(false);
        ButStore5.SetActive(false);

        int Home_1_1_buy = PlayerPrefs.GetInt("Home_1_1_buy");
        if (Home_1_1_buy == 2)
        {
            Home_1_1_prefab.SetActive(true);
            Button_Home_1_1_buy_1.SetActive(false);
            Button_Home_1_2_buy_1.SetActive(true);
        }  

        int Home_1_2_buy = PlayerPrefs.GetInt("Home_1_2_buy");
        if (Home_1_2_buy == 2)
        {
            Home_1_2_prefab.SetActive(true);
            Button_Home_1_2_buy_1.SetActive(false);
            Button_Home_1_3_buy_1.SetActive(true);
        }
        int Home_1_3_buy = PlayerPrefs.GetInt("Home_1_3_buy");
        if (Home_1_3_buy == 2)
        {
            Home_1_3_prefab.SetActive(true);
            Button_Home_1_3_buy_1.SetActive(false);
            Button_Home_1_4_buy_1.SetActive(true);
        } 
        int Home_1_4_buy = PlayerPrefs.GetInt("Home_1_4_buy");
        if (Home_1_4_buy == 2)
        {
            Home_1_4_prefab.SetActive(true);
            Button_Home_1_4_buy_1.SetActive(false);
            Button_Home_1_5_buy_1.SetActive(true);
        } 
        int Home_1_5_buy = PlayerPrefs.GetInt("Home_1_5_buy");
        if (Home_1_5_buy == 2)
        {
            Home_1_5_prefab.SetActive(true);
            Button_Home_1_5_buy_1.SetActive(false);
            Button_Home_1_6_buy_1.SetActive(true);
        } 

        int Home_1_6_buy = PlayerPrefs.GetInt("Home_1_6_buy");
        if (Home_1_6_buy == 2)
        {
            Home_1_6_prefab.SetActive(true);
            Button_Home_1_6_buy_1.SetActive(false);
            Button_Home_1_7_buy_1.SetActive(true);
        } 

        int Home_1_7_buy = PlayerPrefs.GetInt("Home_1_7_buy");
        if (Home_1_7_buy == 2)
        {
            Home_1_7_prefab.SetActive(true);
            Button_Home_1_7_buy_1.SetActive(false);
            Button_Home_1_8_buy_1.SetActive(true);
        } 

        int Home_1_8_buy = PlayerPrefs.GetInt("Home_1_8_buy");
        if (Home_1_8_buy == 2)
        {
            Home_1_8_prefab.SetActive(true);
            Button_Home_1_8_buy_1.SetActive(false);
            Button_Home_1_9_buy_1.SetActive(true);
        } 

        int Home_1_9_buy = PlayerPrefs.GetInt("Home_1_9_buy");
        if (Home_1_9_buy == 2)
        {
            Home_1_9_prefab.SetActive(true);
            Button_Home_1_9_buy_1.SetActive(false);
            Button_Home_1_9_buy_2.SetActive(true);
        } 


        int Home_2_1_buy = PlayerPrefs.GetInt("Home_2_1_buy");
        if (Home_2_1_buy == 2)
        {
            Home_1_1_prefab.SetActive(false);
            Home_2_1_prefab.SetActive(true);
        }  

        int Home_2_2_buy = PlayerPrefs.GetInt("Home_2_2_buy");
        if (Home_2_2_buy == 2)
        {
            Home_1_2_prefab.SetActive(false);
            Home_2_2_prefab.SetActive(true);
        }

        int Home_2_3_buy = PlayerPrefs.GetInt("Home_2_3_buy");
        if (Home_2_3_buy == 2)
        {
            Home_1_3_prefab.SetActive(false);
            Home_2_3_prefab.SetActive(true);
        } 

        int Home_2_4_buy = PlayerPrefs.GetInt("Home_2_4_buy");
        if (Home_2_4_buy == 2)
        {
            Home_1_4_prefab.SetActive(false);
            Home_2_4_prefab.SetActive(true);
        } 

        int Home_2_5_buy = PlayerPrefs.GetInt("Home_2_5_buy");
        if (Home_2_5_buy == 2)
        {
            Home_1_5_prefab.SetActive(false);
            Home_2_5_prefab.SetActive(true);
        } 

        int Home_2_6_buy = PlayerPrefs.GetInt("Home_2_6_buy");
        if (Home_2_6_buy == 2)
        {
            Home_1_6_prefab.SetActive(false);
            Home_2_6_prefab.SetActive(true);
        } 

        int Home_2_7_buy = PlayerPrefs.GetInt("Home_2_7_buy");
        if (Home_2_7_buy == 2)
        {
            Home_1_7_prefab.SetActive(false);
            Home_2_7_prefab.SetActive(true);
        } 

        int Home_2_8_buy = PlayerPrefs.GetInt("Home_2_8_buy");
        if (Home_2_8_buy == 2)
        {
            Home_1_8_prefab.SetActive(false);
            Home_2_8_prefab.SetActive(true);
        } 

        int Home_2_9_buy = PlayerPrefs.GetInt("Home_2_9_buy");
        if (Home_2_9_buy == 2)
        {
            Home_1_9_prefab.SetActive(false);
            Home_2_9_prefab.SetActive(true);
        } 
        int Home_3_1_buy = PlayerPrefs.GetInt("Home_3_1_buy");
        if (Home_3_1_buy == 2)
        {
            Home_2_1_prefab.SetActive(false);
            Home_3_1_prefab.SetActive(true);
        }  

        int Home_3_2_buy = PlayerPrefs.GetInt("Home_3_2_buy");
        if (Home_3_2_buy == 2)
        {
            Home_2_2_prefab.SetActive(false);
            Home_3_2_prefab.SetActive(true);
        }

        int Home_3_3_buy = PlayerPrefs.GetInt("Home_3_3_buy");
        if (Home_3_3_buy == 2)
        {
            Home_2_3_prefab.SetActive(false);
            Home_3_3_prefab.SetActive(true);
        } 

        int Home_3_4_buy = PlayerPrefs.GetInt("Home_3_4_buy");
        if (Home_3_4_buy == 2)
        {
            Home_2_4_prefab.SetActive(false);
            Home_3_4_prefab.SetActive(true);
        } 

        int Home_3_5_buy = PlayerPrefs.GetInt("Home_3_5_buy");
        if (Home_3_5_buy == 2)
        {
            Home_2_5_prefab.SetActive(false);
            Home_3_5_prefab.SetActive(true);
        } 

        int Home_3_6_buy = PlayerPrefs.GetInt("Home_3_6_buy");
        if (Home_3_6_buy == 2)
        {
            Home_2_6_prefab.SetActive(false);
            Home_3_6_prefab.SetActive(true);
        } 

        int Home_3_7_buy = PlayerPrefs.GetInt("Home_3_7_buy");
        if (Home_3_7_buy == 2)
        {
            Home_2_7_prefab.SetActive(false);
            Home_3_7_prefab.SetActive(true);
        } 

        int Home_3_8_buy = PlayerPrefs.GetInt("Home_3_8_buy");
        if (Home_3_8_buy == 2)
        {
            Home_2_8_prefab.SetActive(false);
            Home_3_8_prefab.SetActive(true);
        } 

        int Home_3_9_buy = PlayerPrefs.GetInt("Home_3_9_buy");
        if (Home_3_9_buy == 2)
        {
            Home_2_9_prefab.SetActive(false);
            Home_3_9_prefab.SetActive(true);
        }


    }

    void Update()
    {

        int loadsum = PlayerPrefs.GetInt("summ");
        summ = loadsum;
        textSum.text = summ.ToString();

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
            Home_2_1_panel.SetActive(false); 
            Home_2_2_panel.SetActive(false); 
            Home_2_3_panel.SetActive(false);
            Home_2_4_panel.SetActive(false); 
            Home_2_5_panel.SetActive(false); 
            Home_2_6_panel.SetActive(false); 
            Home_2_7_panel.SetActive(false); 
            Home_2_8_panel.SetActive(false); 
            Home_2_9_panel.SetActive(false);
            //Home_3_1_panel.SetActive(false); 
            //Home_3_2_panel.SetActive(false); 
            //Home_3_3_panel.SetActive(false);
            //Home_3_4_panel.SetActive(false); 
            //Home_3_5_panel.SetActive(false); 
            //Home_3_6_panel.SetActive(false); 
            //Home_3_7_panel.SetActive(false); 
            //Home_3_8_panel.SetActive(false); 
            //Home_3_9_panel.SetActive(false);
        }
        int Home_1_1_load = PlayerPrefs.GetInt("Home_1_1_buy");
        Home_1_1_buy = Home_1_1_load;
        if(Home_1_1_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=1;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_1_2_load = PlayerPrefs.GetInt("Home_1_2_buy");
        Home_1_2_buy = Home_1_2_load;
        if(Home_1_2_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=1;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_1_3_load = PlayerPrefs.GetInt("Home_1_3_buy");
        Home_1_3_buy = Home_1_3_load;
        if(Home_1_3_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=1;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_1_4_load = PlayerPrefs.GetInt("Home_1_4_buy");
        Home_1_4_buy = Home_1_4_load;
        if(Home_1_4_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=1;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_1_5_load = PlayerPrefs.GetInt("Home_1_5_buy");
        Home_1_5_buy = Home_1_5_load;
        if(Home_1_5_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=1;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_1_6_load = PlayerPrefs.GetInt("Home_1_6_buy");
        Home_1_6_buy = Home_1_6_load;
        if(Home_1_6_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=1;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_1_7_load = PlayerPrefs.GetInt("Home_1_7_buy");
        Home_1_7_buy = Home_1_7_load;
        if(Home_1_7_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=1;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_1_8_load = PlayerPrefs.GetInt("Home_1_8_buy");
        Home_1_8_buy = Home_1_8_load;
        if(Home_1_8_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=1;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_1_9_load = PlayerPrefs.GetInt("Home_1_9_buy");
        Home_1_9_buy = Home_1_9_load;
        if(Home_1_9_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=1;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_2_1_load = PlayerPrefs.GetInt("Home_2_1_buy");
        Home_2_1_buy = Home_2_1_load;
        if(Home_2_1_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=3;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_2_2_load = PlayerPrefs.GetInt("Home_2_2_buy");
        Home_2_2_buy = Home_2_2_load;
        if(Home_2_2_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=3;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_2_3_load = PlayerPrefs.GetInt("Home_2_3_buy");
        Home_2_3_buy = Home_2_3_load;
        if(Home_2_3_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=3;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_2_4_load = PlayerPrefs.GetInt("Home_2_4_buy");
        Home_2_4_buy = Home_2_4_load;
        if(Home_2_4_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=3;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_2_5_load = PlayerPrefs.GetInt("Home_2_5_buy");
        Home_2_5_buy = Home_2_5_load;
        if(Home_2_5_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=3;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_2_6_load = PlayerPrefs.GetInt("Home_2_6_buy");
        Home_2_6_buy = Home_2_6_load;
        if(Home_2_6_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=3;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_2_7_load = PlayerPrefs.GetInt("Home_2_7_buy");
        Home_2_7_buy = Home_2_7_load;
        if(Home_2_7_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=3;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_2_8_load = PlayerPrefs.GetInt("Home_2_8_buy");
        Home_2_8_buy = Home_2_8_load;
        if(Home_2_8_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=3;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_2_9_load = PlayerPrefs.GetInt("Home_2_9_buy");
        Home_2_9_buy = Home_2_9_load;
        if(Home_2_9_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=3;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }
        
        int Home_3_1_load = PlayerPrefs.GetInt("Home_3_1_buy");
        Home_3_1_buy = Home_3_1_load;
        if(Home_3_1_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=5;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_3_2_load = PlayerPrefs.GetInt("Home_3_2_buy");
        Home_3_2_buy = Home_3_2_load;
        if(Home_3_2_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=5;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_3_3_load = PlayerPrefs.GetInt("Home_3_3_buy");
        Home_3_3_buy = Home_3_3_load;
        if(Home_3_3_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=5;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_3_4_load = PlayerPrefs.GetInt("Home_3_4_buy");
        Home_3_4_buy = Home_3_4_load;
        if(Home_3_4_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=5;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_3_5_load = PlayerPrefs.GetInt("Home_3_5_buy");
        Home_3_5_buy = Home_3_5_load;
        if(Home_3_5_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=5;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_3_6_load = PlayerPrefs.GetInt("Home_3_6_buy");
        Home_3_6_buy = Home_3_6_load;
        if(Home_3_6_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=5;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_3_7_load = PlayerPrefs.GetInt("Home_3_7_buy");
        Home_3_7_buy = Home_3_7_load;
        if(Home_3_7_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=5;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_3_8_load = PlayerPrefs.GetInt("Home_3_8_buy");
        Home_3_8_buy = Home_3_8_load;
        if(Home_3_8_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=5;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }

        int Home_3_9_load = PlayerPrefs.GetInt("Home_3_9_buy");
        Home_3_9_buy = Home_3_9_load;
        if(Home_3_9_buy == 2)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=5;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }
    }
    public void OpenStoreMenu_1()
    {
        ButStore.SetActive(true);
        ButStore2.SetActive(false);
        ButStore3.SetActive(false);
        ButStore4.SetActive(false);
        ButStore5.SetActive(false);
        shop1 = 2;
        PlayerPrefs.SetInt("shop1", shop1);
        PlayerPrefs.Save();
        Debug.Log("Открыли");
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void panelClose()
    {
        Panel_no_money.SetActive(false);
    }
    public void saleClose()
    {
        Panel_okey_buy.SetActive(false);
    }
    public void CloseStoreMenu_1()
    {
        ButStore.SetActive(false);
        shop1 = 1;
        shop2 = 1;
        shop3 = 1;
        shop4 = 1;
        shop5 = 1;
        PlayerPrefs.SetInt("shop2", shop2);
        PlayerPrefs.SetInt("shop1", shop1);
        PlayerPrefs.SetInt("shop3", shop3);
        PlayerPrefs.SetInt("shop4", shop4);
        PlayerPrefs.SetInt("shop5", shop5);
        PlayerPrefs.Save();
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void OpenStoreMenu_2()
    {
        ButStore.SetActive(false);
        ButStore2.SetActive(true);
        ButStore3.SetActive(false);
        ButStore4.SetActive(false);
        ButStore5.SetActive(false);
        shop2 = 2;
        PlayerPrefs.SetInt("shop2", shop2);
        PlayerPrefs.Save();
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseStoreMenu_2()
    {
        ButStore2.SetActive(false);
        shop1 = 1;
        shop2 = 1;
        shop3 = 1;
        shop4 = 1;
        shop5 = 1;
        PlayerPrefs.SetInt("shop2", shop2);
        PlayerPrefs.SetInt("shop1", shop1);
        PlayerPrefs.SetInt("shop3", shop3);
        PlayerPrefs.SetInt("shop4", shop4);
        PlayerPrefs.SetInt("shop5", shop5);
        PlayerPrefs.Save();
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void OpenStoreMenu_3()
    {
        ButStore.SetActive(false);
        ButStore2.SetActive(false);
        ButStore3.SetActive(true);
        ButStore4.SetActive(false);
        ButStore5.SetActive(false);
        shop3 = 2;
        PlayerPrefs.SetInt("shop3", shop3);
        PlayerPrefs.Save();
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseStoreMenu_3()
    {
        ButStore3.SetActive(false);
        shop1 = 1;
        shop2 = 1;
        shop3 = 1;
        shop4 = 1;
        shop5 = 1;
        PlayerPrefs.SetInt("shop2", shop2);
        PlayerPrefs.SetInt("shop1", shop1);
        PlayerPrefs.SetInt("shop3", shop3);
        PlayerPrefs.SetInt("shop4", shop4);
        PlayerPrefs.SetInt("shop5", shop5);
        PlayerPrefs.Save();
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void OpenStoreMenu_4()
    {
        ButStore.SetActive(false);
        ButStore2.SetActive(false);
        ButStore3.SetActive(false);
        ButStore4.SetActive(true);
        ButStore5.SetActive(false);
        shop4 = 2;
        PlayerPrefs.SetInt("shop4", shop4);
        PlayerPrefs.Save();
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }

    public void CloseStoreMenu_4()
    {
        ButStore4.SetActive(false);
        shop1 = 1;
        shop2 = 1;
        shop3 = 1;
        shop4 = 1;
        shop5 = 1;
        PlayerPrefs.SetInt("shop2", shop2);
        PlayerPrefs.SetInt("shop1", shop1);
        PlayerPrefs.SetInt("shop3", shop3);
        PlayerPrefs.SetInt("shop4", shop4);
        PlayerPrefs.SetInt("shop5", shop5);
        PlayerPrefs.Save();
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }

    public void OpenStoreMenu_5()
    {
        ButStore.SetActive(false);
        ButStore2.SetActive(false);
        ButStore3.SetActive(false);
        ButStore4.SetActive(false);
        ButStore5.SetActive(true);
        shop5 = 2;
        PlayerPrefs.SetInt("shop5", shop5);
        PlayerPrefs.Save();
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }

    public void CloseStoreMenu_5()
    {
        ButStore5.SetActive(false);
        shop1 = 1;
        shop2 = 1;
        shop3 = 1;
        shop4 = 1;
        shop5 = 1;
        PlayerPrefs.SetInt("shop2", shop2);
        PlayerPrefs.SetInt("shop1", shop1);
        PlayerPrefs.SetInt("shop3", shop3);
        PlayerPrefs.SetInt("shop4", shop4);
        PlayerPrefs.SetInt("shop5", shop5);
        PlayerPrefs.Save();
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_1_1()
    {
        Home_1_1_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_1_2()
    {
        Home_1_2_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_1_3()
    {
        Home_1_3_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_1_4()
    {
        Home_1_4_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_1_5()
    {
        Home_1_5_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_1_6()
    {
        Home_1_6_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_1_7()
    {
        Home_1_7_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_1_8()
    {
        Home_1_8_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_1_9()
    {
        Home_1_9_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }

    public void CloseHome_2_1()
    {
        Home_2_1_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_2_2()
    {
        Home_2_2_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_2_3()
    {
        Home_2_3_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_2_4()
    {
        Home_2_4_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_2_5()
    {
        Home_2_5_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_2_6()
    {
        Home_2_6_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_2_7()
    {
        Home_2_7_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_2_8()
    {
        Home_2_8_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_2_9()
    {
        Home_2_9_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }

    public void CloseHome_3_1()
    {
        Home_3_1_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_3_2()
    {
        Home_3_2_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_3_3()
    {
        Home_3_3_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_3_4()
    {
        Home_3_4_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_3_5()
    {
        Home_3_5_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_3_6()
    {
        Home_3_6_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_3_7()
    {
        Home_3_7_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_3_8()
    {
        Home_3_8_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void CloseHome_3_9()
    {
        Home_3_9_panel.SetActive(false);
        Panel_no_money.SetActive(false);
        Panel_okey_buy.SetActive(false);
    }
    public void BuyStoreHome_1_1()
    {
        nameBuy = "Home_1_1";
        BuyStore();
    }
    public void BuyStoreHome_1_2()
    {
        nameBuy = "Home_1_2";
        BuyStore();
    }
    public void BuyStoreHome_1_3()
    {
        nameBuy = "Home_1_3";
        BuyStore();
    }
    public void BuyStoreHome_1_4()
    {
        nameBuy = "Home_1_4";
        BuyStore();
    }
    public void BuyStoreHome_1_5()
    {
        nameBuy = "Home_1_5";
        BuyStore();
    }
    public void BuyStoreHome_1_6()
    {
        nameBuy = "Home_1_6";
        BuyStore();
    }
    public void BuyStoreHome_1_7()
    {
        nameBuy = "Home_1_7";
        BuyStore();
    }
    public void BuyStoreHome_1_8()
    {
        nameBuy = "Home_1_8";
        BuyStore();
    }
    public void BuyStoreHome_1_9()
    {
        nameBuy = "Home_1_9";
        BuyStore();
    }

    public void BuyStoreHome_2_1()
    {
        nameBuy = "Home_2_1";
        BuyStore();
    }
    public void BuyStoreHome_2_2()
    {
        nameBuy = "Home_2_2";
        BuyStore();
    }
    public void BuyStoreHome_2_3()
    {
        nameBuy = "Home_2_3";
        BuyStore();
    }
    public void BuyStoreHome_2_4()
    {
        nameBuy = "Home_2_4";
        BuyStore();
    }
    public void BuyStoreHome_2_5()
    {
        nameBuy = "Home_2_5";
        BuyStore();
    }
    public void BuyStoreHome_2_6()
    {
        nameBuy = "Home_2_6";
        BuyStore();
    }
    public void BuyStoreHome_2_7()
    {
        nameBuy = "Home_2_7";
        BuyStore();
    }
    public void BuyStoreHome_2_8()
    {
        nameBuy = "Home_2_8";
        BuyStore();
    }
    public void BuyStoreHome_2_9()
    {
        nameBuy = "Home_2_9";
        BuyStore();
    }

    public void BuyStoreHome_3_1()
    {
        nameBuy = "Home_3_1";
        BuyStore();
    }
    public void BuyStoreHome_3_2()
    {
        nameBuy = "Home_3_2";
        BuyStore();
    }
    public void BuyStoreHome_3_3()
    {
        nameBuy = "Home_3_3";
        BuyStore();
    }
    public void BuyStoreHome_3_4()
    {
        nameBuy = "Home_3_4";
        BuyStore();
    }
    public void BuyStoreHome_3_5()
    {
        nameBuy = "Home_3_5";
        BuyStore();
    }
    public void BuyStoreHome_3_6()
    {
        nameBuy = "Home_3_6";
        BuyStore();
    }
    public void BuyStoreHome_3_7()
    {
        nameBuy = "Home_3_7";
        BuyStore();
    }
    public void BuyStoreHome_3_8()
    {
        nameBuy = "Home_3_8";
        BuyStore();
    }
    public void BuyStoreHome_3_9()
    {
        nameBuy = "Home_3_9";
        BuyStore();
    }

    public void BuyStore()
    {
    if (nameBuy == "Home_1_1" && summ >= 200)
        {
            if (Home_1_1_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_1_1";
                    price = 200;
                    StartCoroutine(BuyProduct());
                    summ-=200;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_1_1_buy = 2;
                    PlayerPrefs.SetInt("Home_1_1_buy", Home_1_1_buy);
                    PlayerPrefs.Save();
                    Home_1_1_prefab.SetActive(true);
                    Button_Home_1_1_buy_1.SetActive(false);
                    Button_Home_1_2_buy_1.SetActive(true);
                }
        }
    else if (nameBuy == "Home_1_2" && summ >= 200)
        {
            if (Home_1_2_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_1_2";
                    price = 200;
                    StartCoroutine(BuyProduct());
                    summ-=200;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_1_2_buy = 2;
                    PlayerPrefs.SetInt("Home_1_2_buy", Home_1_2_buy);
                    PlayerPrefs.Save();
                    Home_1_2_prefab.SetActive(true);
                    Button_Home_1_2_buy_1.SetActive(false);
                    Button_Home_1_3_buy_1.SetActive(true);
                }
        }
    else if (nameBuy == "Home_1_3" && summ >= 200)
        {
            if (Home_1_3_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_1_3";
                    price = 200;
                    StartCoroutine(BuyProduct());
                    summ-=200;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_1_3_buy = 2;
                    PlayerPrefs.SetInt("Home_1_3_buy", Home_1_3_buy);
                    PlayerPrefs.Save();
                    Home_1_3_prefab.SetActive(true);
                    Button_Home_1_3_buy_1.SetActive(false);
                    Button_Home_1_4_buy_1.SetActive(true);
                }
        }
    else if (nameBuy == "Home_1_4" && summ >= 200)
        {
            if (Home_1_4_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_1_4";
                    price = 200;
                    StartCoroutine(BuyProduct());
                    summ-=200;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_1_4_buy = 2;
                    PlayerPrefs.SetInt("Home_1_4_buy", Home_1_4_buy);
                    PlayerPrefs.Save();
                    Home_1_4_prefab.SetActive(true);
                    Button_Home_1_4_buy_1.SetActive(false);
                    Button_Home_1_5_buy_1.SetActive(true);
                }
        }
    else if (nameBuy == "Home_1_5" && summ >= 200)
        {
            if (Home_1_5_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_1_5";
                    price = 200;
                    StartCoroutine(BuyProduct());
                    summ-=200;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_1_5_buy = 2;
                    PlayerPrefs.SetInt("Home_1_5_buy", Home_1_5_buy);
                    PlayerPrefs.Save();
                    Home_1_5_prefab.SetActive(true);
                    Button_Home_1_5_buy_1.SetActive(false);
                    Button_Home_1_6_buy_1.SetActive(true);
                }
        }
    else if (nameBuy == "Home_1_6" && summ >= 200)
        {
            if (Home_1_6_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_1_6";
                    price = 200;
                    StartCoroutine(BuyProduct());
                    summ-=200;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_1_6_buy = 2;
                    PlayerPrefs.SetInt("Home_1_6_buy", Home_1_6_buy);
                    PlayerPrefs.Save();
                    Home_1_6_prefab.SetActive(true);
                    Button_Home_1_6_buy_1.SetActive(false);
                    Button_Home_1_7_buy_1.SetActive(true);
                }
        }
    else if (nameBuy == "Home_1_7" && summ >= 200)
        {
            if (Home_1_7_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_1_7";
                    price = 200;
                    StartCoroutine(BuyProduct());
                    summ-=200;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_1_7_buy = 2;
                    PlayerPrefs.SetInt("Home_1_7_buy", Home_1_7_buy);
                    PlayerPrefs.Save();
                    Home_1_7_prefab.SetActive(true);
                    Button_Home_1_7_buy_1.SetActive(false);
                    Button_Home_1_8_buy_1.SetActive(true);
                }
        }
    else if (nameBuy == "Home_1_8" && summ >= 200)
        {
            if (Home_1_8_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_1_8";
                    price = 200;
                    StartCoroutine(BuyProduct());
                    summ-=200;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_1_8_buy = 2;
                    PlayerPrefs.SetInt("Home_1_8_buy", Home_1_8_buy);
                    PlayerPrefs.Save();
                    Home_1_8_prefab.SetActive(true);
                    Button_Home_1_8_buy_1.SetActive(false);
                    Button_Home_1_9_buy_1.SetActive(true);
                }
        }
    else if (nameBuy == "Home_1_9" && summ >= 200)
        {
            if (Home_1_9_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_1_9";
                    price = 200;
                    StartCoroutine(BuyProduct());
                    summ-=200;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_1_9_buy = 2;
                    PlayerPrefs.SetInt("Home_1_9_buy", Home_1_9_buy);
                    PlayerPrefs.Save();
                    Home_1_9_prefab.SetActive(true);
                    Button_Home_1_9_buy_1.SetActive(false);
                    Button_Home_1_9_buy_2.SetActive(true);
                }
        }

    else if (nameBuy == "Home_2_1" && summ >= 350)
        {
            if (Home_2_1_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_2_1";
                    price = 350;
                    StartCoroutine(BuyProduct());
                    summ-=350;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_2_1_buy = 2;
                    Home_1_1_buy = 3;
                    PlayerPrefs.SetInt("Home_2_1_buy", Home_2_1_buy);
                    PlayerPrefs.SetInt("Home_1_1_buy", Home_1_1_buy);
                    PlayerPrefs.Save();
                    Home_1_1_prefab.SetActive(false);
                    Home_2_1_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Home_2_2" && summ >= 350)
        {
            if (Home_2_2_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_2_2";
                    price = 350;
                    StartCoroutine(BuyProduct());
                    summ-=350;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_2_2_buy = 2;
                    Home_1_2_buy = 3;
                    PlayerPrefs.SetInt("Home_2_2_buy", Home_2_2_buy);
                    PlayerPrefs.SetInt("Home_1_2_buy", Home_1_2_buy);
                    PlayerPrefs.Save();
                    Home_1_2_prefab.SetActive(false);
                    Home_2_2_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Home_2_3" && summ >= 350)
        {
            if (Home_2_3_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_2_3";
                    price = 350;
                    StartCoroutine(BuyProduct());
                    summ-=350;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_2_3_buy = 2;
                    Home_1_3_buy = 3;
                    PlayerPrefs.SetInt("Home_2_3_buy", Home_2_3_buy);
                    PlayerPrefs.SetInt("Home_1_3_buy", Home_1_3_buy);
                    PlayerPrefs.Save();
                    Home_1_3_prefab.SetActive(false);
                    Home_2_3_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Home_2_4" && summ >= 350)
        {
            if (Home_2_4_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_2_4";
                    price = 350;
                    StartCoroutine(BuyProduct());
                    summ-=350;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_2_4_buy = 2;
                    Home_1_4_buy = 3;
                    PlayerPrefs.SetInt("Home_2_4_buy", Home_2_4_buy);
                    PlayerPrefs.SetInt("Home_1_4_buy", Home_1_4_buy);
                    PlayerPrefs.Save();
                    Home_1_4_prefab.SetActive(false);
                    Home_2_4_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Home_2_5" && summ >= 350)
        {
            if (Home_2_5_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_2_5";
                    price = 350;
                    StartCoroutine(BuyProduct());
                    summ-=350;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_2_5_buy = 2;
                    Home_1_5_buy = 3;
                    PlayerPrefs.SetInt("Home_2_5_buy", Home_2_5_buy);
                    PlayerPrefs.SetInt("Home_1_5_buy", Home_1_5_buy);
                    PlayerPrefs.Save();
                    Home_1_5_prefab.SetActive(false);
                    Home_2_5_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Home_2_6" && summ >= 350)
        {
            if (Home_2_6_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_2_6";
                    price = 350;
                    StartCoroutine(BuyProduct());
                    summ-=350;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_2_6_buy = 2;
                    Home_1_6_buy = 3;
                    PlayerPrefs.SetInt("Home_2_6_buy", Home_2_6_buy);
                    PlayerPrefs.SetInt("Home_1_6_buy", Home_1_6_buy);
                    PlayerPrefs.Save();
                    Home_1_6_prefab.SetActive(false);
                    Home_2_6_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Home_2_7" && summ >= 350)
        {
            if (Home_2_7_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_2_7";
                    price = 350;
                    StartCoroutine(BuyProduct());
                    summ-=350;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_2_7_buy = 2;
                    Home_1_7_buy = 3;
                    PlayerPrefs.SetInt("Home_2_7_buy", Home_2_7_buy);
                    PlayerPrefs.SetInt("Home_1_7_buy", Home_1_7_buy);
                    PlayerPrefs.Save();
                    Home_1_7_prefab.SetActive(false);
                    Home_2_7_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Home_2_8" && summ >= 350)
        {
            if (Home_2_8_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_2_8";
                    price = 350;
                    StartCoroutine(BuyProduct());
                    summ-=350;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_2_8_buy = 2;
                    Home_1_8_buy = 3;
                    PlayerPrefs.SetInt("Home_2_8_buy", Home_2_8_buy);
                    PlayerPrefs.SetInt("Home_1_8_buy", Home_1_8_buy);
                    PlayerPrefs.Save();
                    Home_1_8_prefab.SetActive(false);
                    Home_2_8_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Home_2_9" && summ >= 350)
        {
            if (Home_2_9_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_2_9";
                    price = 350;
                    StartCoroutine(BuyProduct());
                    summ-=350;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_2_9_buy = 2;
                    Home_1_9_buy = 3;
                    PlayerPrefs.SetInt("Home_2_9_buy", Home_2_9_buy);
                    PlayerPrefs.SetInt("Home_1_9_buy", Home_1_9_buy);
                    PlayerPrefs.Save();
                    Home_1_9_prefab.SetActive(false);
                    Home_2_9_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Home_3_1" && summ >= 500)
        {
            if (Home_3_1_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_3_2";
                    price = 500;
                    StartCoroutine(BuyProduct());
                    summ-=500;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_3_1_buy = 2;
                    Home_2_1_buy = 3;
                    PlayerPrefs.SetInt("Home_3_1_buy", Home_3_1_buy);
                    PlayerPrefs.SetInt("Home_2_1_buy", Home_2_1_buy);
                    PlayerPrefs.Save();
                    Home_2_1_prefab.SetActive(false);
                    Home_3_1_prefab.SetActive(true);
                }
        }

    else if (nameBuy == "Home_3_2" && summ >= 500)
        {
            if (Home_3_2_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_3_2";
                    price = 500;
                    StartCoroutine(BuyProduct());
                    summ-=500;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_3_2_buy = 2;
                    Home_2_2_buy = 3;
                    PlayerPrefs.SetInt("Home_3_2_buy", Home_3_2_buy);
                    PlayerPrefs.SetInt("Home_2_3_buy", Home_2_2_buy);
                    PlayerPrefs.Save();
                    Home_2_2_prefab.SetActive(false);
                    Home_3_2_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Home_3_3" && summ >= 500)
        {
            if (Home_3_3_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_3_3";
                    price = 500;
                    StartCoroutine(BuyProduct());
                    summ-=500;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_3_3_buy = 2;
                    Home_2_3_buy = 3;
                    PlayerPrefs.SetInt("Home_3_3_buy", Home_3_3_buy);
                    PlayerPrefs.SetInt("Home_2_3_buy", Home_2_3_buy);
                    PlayerPrefs.Save();
                    Home_2_3_prefab.SetActive(false);
                    Home_3_3_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Home_3_4" && summ >= 500)
        {
            if (Home_3_4_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_3_4";
                    price = 500;
                    StartCoroutine(BuyProduct());
                    summ-=500;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_3_4_buy = 2;
                    Home_2_4_buy = 3;
                    PlayerPrefs.SetInt("Home_3_4_buy", Home_3_4_buy);
                    PlayerPrefs.SetInt("Home_2_4_buy", Home_2_4_buy);
                    PlayerPrefs.Save();
                    Home_2_4_prefab.SetActive(false);
                    Home_3_4_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Home_3_5" && summ >= 500)
        {
            if (Home_3_5_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_3_5";
                    price = 500;
                    StartCoroutine(BuyProduct());
                    summ-=500;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_3_5_buy = 2;
                    Home_2_5_buy = 3;
                    PlayerPrefs.SetInt("Home_3_5_buy", Home_3_5_buy);
                    PlayerPrefs.SetInt("Home_2_5_buy", Home_2_5_buy);
                    PlayerPrefs.Save();
                    Home_2_5_prefab.SetActive(false);
                    Home_3_5_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Home_3_6" && summ >= 500)
        {
            if (Home_3_6_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_3_6";
                    price = 500;
                    StartCoroutine(BuyProduct());
                    summ-=500;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_3_6_buy = 2;
                    Home_2_6_buy = 3;
                    PlayerPrefs.SetInt("Home_3_6_buy", Home_3_6_buy);
                    PlayerPrefs.SetInt("Home_2_6_buy", Home_2_6_buy);
                    PlayerPrefs.Save();
                    Home_2_6_prefab.SetActive(false);
                    Home_3_6_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Home_3_7" && summ >= 500)
        {
            if (Home_3_7_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_3_7";
                    price = 500;
                    StartCoroutine(BuyProduct());
                    summ-=500;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_3_7_buy = 2;
                    Home_2_7_buy = 3;
                    PlayerPrefs.SetInt("Home_3_7_buy", Home_3_7_buy);
                    PlayerPrefs.SetInt("Home_2_7_buy", Home_2_7_buy);
                    PlayerPrefs.Save();
                    Home_2_7_prefab.SetActive(false);
                    Home_3_7_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Home_3_8" && summ >= 500)
        {
            if (Home_3_8_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_3_8";
                    price = 500;
                    StartCoroutine(BuyProduct());
                    summ-=500;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_3_8_buy = 2;
                    Home_2_8_buy = 3;
                    PlayerPrefs.SetInt("Home_3_8_buy", Home_3_8_buy);
                    PlayerPrefs.SetInt("Home_2_8_buy", Home_2_8_buy);
                    PlayerPrefs.Save();
                    Home_2_8_prefab.SetActive(false);
                    Home_3_8_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Home_3_9" && summ >= 500)
        {
            if (Home_3_9_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Home_3_9";
                    price = 500;
                    StartCoroutine(BuyProduct());
                    summ-=500;
                    PlayerPrefs.SetInt("summ", summ);
                    Home_3_9_buy = 2;
                    Home_2_9_buy = 3;
                    PlayerPrefs.SetInt("Home_3_9_buy", Home_3_9_buy);
                    PlayerPrefs.SetInt("Home_2_9_buy", Home_2_9_buy);
                    PlayerPrefs.Save();
                    Home_2_9_prefab.SetActive(false);
                    Home_3_9_prefab.SetActive(true);
                }
        }
    else
        {
            panelBox.SetActive(true);
        }
        //int loadsum = PlayerPrefs.GetInt("summ");
        //summ = loadsum;
        //textSum.text = summ.ToString();
        int Home_1_1_load = PlayerPrefs.GetInt("Home_1_1_buy");
        Home_1_1_buy = Home_1_1_load;

        int Home_1_2_load = PlayerPrefs.GetInt("Home_1_2_buy");
        Home_1_2_buy = Home_1_2_load;

        int Home_1_3_load = PlayerPrefs.GetInt("Home_1_3_buy");
        Home_1_3_buy = Home_1_3_load;

        int Home_1_4_load = PlayerPrefs.GetInt("Home_1_4_buy");
        Home_1_4_buy = Home_1_4_load;

        int Home_1_5_load = PlayerPrefs.GetInt("Home_1_5_buy");
        Home_1_5_buy = Home_1_5_load;

        int Home_1_6_load = PlayerPrefs.GetInt("Home_1_6_buy");
        Home_1_6_buy = Home_1_6_load;

        int Home_1_7_load = PlayerPrefs.GetInt("Home_1_7_buy");
        Home_1_7_buy = Home_1_7_load;

        int Home_1_8_load = PlayerPrefs.GetInt("Home_1_8_buy");
        Home_1_8_buy = Home_1_8_load;

        int Home_1_9_load = PlayerPrefs.GetInt("Home_1_9_buy");
        Home_1_9_buy = Home_1_9_load;
    
        int Home_2_1_load = PlayerPrefs.GetInt("Home_2_1_buy");
        Home_2_1_buy = Home_2_1_load;

        int Home_2_2_load = PlayerPrefs.GetInt("Home_2_2_buy");
        Home_2_2_buy = Home_2_2_load;

        int Home_2_3_load = PlayerPrefs.GetInt("Home_2_3_buy");
        Home_2_3_buy = Home_2_3_load;

        int Home_2_4_load = PlayerPrefs.GetInt("Home_2_4_buy");
        Home_2_4_buy = Home_2_4_load;

        int Home_2_5_load = PlayerPrefs.GetInt("Home_2_5_buy");
        Home_2_5_buy = Home_2_5_load;

        int Home_2_6_load = PlayerPrefs.GetInt("Home_2_6_buy");
        Home_2_6_buy = Home_2_6_load;

        int Home_2_7_load = PlayerPrefs.GetInt("Home_2_7_buy");
        Home_2_7_buy = Home_2_7_load;

        int Home_2_8_load = PlayerPrefs.GetInt("Home_2_8_buy");
        Home_2_8_buy = Home_2_8_load;

        int Home_2_9_load = PlayerPrefs.GetInt("Home_2_9_buy");
        Home_2_9_buy = Home_2_9_load;

        int Home_3_1_load = PlayerPrefs.GetInt("Home_3_1_buy");
        Home_3_1_buy = Home_3_1_load;

        int Home_3_2_load = PlayerPrefs.GetInt("Home_3_2_buy");
        Home_3_2_buy = Home_3_2_load;

        int Home_3_3_load = PlayerPrefs.GetInt("Home_3_3_buy");
        Home_3_3_buy = Home_3_3_load;

        int Home_3_4_load = PlayerPrefs.GetInt("Home_3_4_buy");
        Home_3_4_buy = Home_3_4_load;

        int Home_3_5_load = PlayerPrefs.GetInt("Home_3_5_buy");
        Home_3_5_buy = Home_3_5_load;

        int Home_3_6_load = PlayerPrefs.GetInt("Home_3_6_buy");
        Home_3_6_buy = Home_3_6_load;

        int Home_3_7_load = PlayerPrefs.GetInt("Home_3_7_buy");
        Home_3_7_buy = Home_3_7_load;

        int Home_3_8_load = PlayerPrefs.GetInt("Home_3_8_buy");
        Home_3_8_buy = Home_3_8_load;

        int Home_3_9_load = PlayerPrefs.GetInt("Home_3_9_buy");
        Home_3_9_buy = Home_3_9_load;
    }

    public IEnumerator BuyProduct()
    {
        WWWForm form = new WWWForm();
        form.AddField("Userid", userid);
        form.AddField("Nameprice", nameprice);
        form.AddField("Price", price);
        form.AddField("Sum", summ);
        WWW www = new WWW("https://cities-game.ml/buy_product.php", form);
        yield return www;
        if (www.error != null)
        {
            Debug.Log("Помилка" + www.error);
            yield break;
        }
        Debug.Log("Все ок" + www.text);
    }

    public  IEnumerator PurchaseVerification()
    {
        WWWForm form = new WWWForm();
        form.AddField("Nameprice", nameprice);
        WWW www = new WWW("https://cities-game.ml/purchase_verification.php", form);
        yield return www;
        if (www.error != null)
        {
            Debug.Log("Помилка" + www.error);
            yield break;
        }
        Debug.Log("Все ок" + www.text);


    }

}


