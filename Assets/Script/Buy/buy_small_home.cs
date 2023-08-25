using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class buy_small_home : MonoBehaviour
{   
    private int Small_home_1_1_buy;
    private int Small_home_1_2_buy;
    private int Small_home_1_3_buy;
    private int Small_home_1_4_buy;
    private int Small_home_1_5_buy;
    private int Small_home_1_6_buy;
    private int Small_home_1_7_buy;
    private int Small_home_1_8_buy;
    private int Small_home_1_9_buy;
    private int Small_home_1_10_buy;
    private int Small_home_1_11_buy;
    private int Small_home_1_12_buy;
    private int Small_home_2_1_buy;
    private int Small_home_2_2_buy;
    private int Small_home_2_3_buy;
    private int Small_home_2_4_buy;
    private int Small_home_2_5_buy;
    private int Small_home_2_6_buy;
    private int Small_home_2_7_buy;
    private int Small_home_2_8_buy;
    private int Small_home_2_9_buy;
    private int Small_home_2_10_buy;
    private int Small_home_2_11_buy;
    private int Small_home_2_12_buy;
    private int Small_home_3_1_buy;
    private int Small_home_3_2_buy;
    private int Small_home_3_3_buy;
    private int Small_home_3_4_buy;
    private int Small_home_3_5_buy;
    private int Small_home_3_6_buy;
    private int Small_home_3_7_buy;
    private int Small_home_3_8_buy;
    private int Small_home_3_9_buy;
    private int Small_home_3_10_buy;
    private int Small_home_3_11_buy;
    private int Small_home_3_12_buy;

    private string nameprice;
    private int price;
    private string userid;
    private string loadusers;
    private float time = 60;

    [SerializeField]
    GameObject  Small_home_1_1_prefab,
    Small_home_1_2_prefab,
    Small_home_1_3_prefab,
    Small_home_1_4_prefab,
    Small_home_1_5_prefab,
    Small_home_1_6_prefab,
    Small_home_1_7_prefab,
    Small_home_1_8_prefab,
    Small_home_1_9_prefab,
    Small_home_1_10_prefab,
    Small_home_1_11_prefab,
    Small_home_1_12_prefab,
    Small_home_2_1_prefab,
    Small_home_2_2_prefab,
    Small_home_2_3_prefab,
    Small_home_2_4_prefab,
    Small_home_2_5_prefab,
    Small_home_2_6_prefab,
    Small_home_2_7_prefab,
    Small_home_2_8_prefab,
    Small_home_2_9_prefab,
    Small_home_2_10_prefab,
    Small_home_2_11_prefab,
    Small_home_2_12_prefab,
    Small_home_3_1_prefab,
    Small_home_3_2_prefab,
    Small_home_3_3_prefab,
    Small_home_3_4_prefab,
    Small_home_3_5_prefab,
    Small_home_3_6_prefab,
    Small_home_3_7_prefab,
    Small_home_3_8_prefab,
    Small_home_3_9_prefab,
    Small_home_3_10_prefab,
    Small_home_3_11_prefab,
    Small_home_3_12_prefab;

    [SerializeField]
    GameObject Button_Small_home_1_1_buy_1, 
    Button_Small_home_1_2_buy_1, 
    Button_Small_home_1_3_buy_1, 
    Button_Small_home_1_4_buy_1, 
    Button_Small_home_1_5_buy_1, 
    Button_Small_home_1_6_buy_1, 
    Button_Small_home_1_7_buy_1, 
    Button_Small_home_1_8_buy_1,  
    Button_Small_home_1_9_buy_1,
    Button_Small_home_1_10_buy_1, 
    Button_Small_home_1_11_buy_1,  
    Button_Small_home_1_12_buy_1, Button_Small_home_1_12_buy_2;

    [SerializeField]
    GameObject Small_home_1_1_panel, 
    Small_home_1_2_panel, 
    Small_home_1_3_panel,
    Small_home_1_4_panel, 
    Small_home_1_5_panel, 
    Small_home_1_6_panel, 
    Small_home_1_7_panel, 
    Small_home_1_8_panel, 
    Small_home_1_9_panel,
    Small_home_1_10_panel, 
    Small_home_1_11_panel, 
    Small_home_1_12_panel,
    Small_home_2_1_panel, 
    Small_home_2_2_panel, 
    Small_home_2_3_panel,
    Small_home_2_4_panel, 
    Small_home_2_5_panel, 
    Small_home_2_6_panel, 
    Small_home_2_7_panel, 
    Small_home_2_8_panel, 
    Small_home_2_9_panel,
    Small_home_2_10_panel, 
    Small_home_2_11_panel, 
    Small_home_2_12_panel,
    Small_home_3_1_panel, 
    Small_home_3_2_panel, 
    Small_home_3_3_panel,
    Small_home_3_4_panel, 
    Small_home_3_5_panel, 
    Small_home_3_6_panel, 
    Small_home_3_7_panel, 
    Small_home_3_8_panel, 
    Small_home_3_9_panel,
    Small_home_3_10_panel, 
    Small_home_3_11_panel, 
    Small_home_3_12_panel;
    
    public string nameBuy;
    public int summ;
    public Text textSum;
    public int briliant;
    public Text textBriliant;
    public GameObject panelBox, sales;


    void Start()
    {
        //summ;
        int summ = PlayerPrefs.GetInt("summ");
        textSum.text = summ.ToString();
        int briliant = PlayerPrefs.GetInt("briliant");
        textBriliant.text = briliant.ToString();


        int Small_home_1_1_buy = PlayerPrefs.GetInt("Small_home_1_1_buy");
        if (Small_home_1_1_buy == 2 || Small_home_1_1_buy == 3)
        {
            Small_home_1_1_prefab.SetActive(true);
            Button_Small_home_1_1_buy_1.SetActive(false);
            Button_Small_home_1_2_buy_1.SetActive(true);
        }  

        int Small_home_1_2_buy = PlayerPrefs.GetInt("Small_home_1_2_buy");
        if (Small_home_1_2_buy == 2 || Small_home_1_2_buy == 3)
        {
            Small_home_1_2_prefab.SetActive(true);
            Button_Small_home_1_2_buy_1.SetActive(false);
            Button_Small_home_1_3_buy_1.SetActive(true);
        }
        int Small_home_1_3_buy = PlayerPrefs.GetInt("Small_home_1_3_buy");
        if (Small_home_1_3_buy == 2 || Small_home_1_3_buy == 3)
        {
            Small_home_1_3_prefab.SetActive(true);
            Button_Small_home_1_3_buy_1.SetActive(false);
            Button_Small_home_1_4_buy_1.SetActive(true);
        } 
        int Small_home_1_4_buy = PlayerPrefs.GetInt("Small_home_1_4_buy");
        if (Small_home_1_4_buy == 2 || Small_home_1_4_buy == 3)
        {
            Small_home_1_4_prefab.SetActive(true);
            Button_Small_home_1_4_buy_1.SetActive(false);
            Button_Small_home_1_5_buy_1.SetActive(true);
        } 
        int Small_home_1_5_buy = PlayerPrefs.GetInt("Small_home_1_5_buy");
        if (Small_home_1_5_buy == 2 || Small_home_1_5_buy == 3)
        {
            Small_home_1_5_prefab.SetActive(true);
            Button_Small_home_1_5_buy_1.SetActive(false);
            Button_Small_home_1_6_buy_1.SetActive(true);
        } 

        int Small_home_1_6_buy = PlayerPrefs.GetInt("Small_home_1_6_buy");
        if (Small_home_1_6_buy == 2 || Small_home_1_6_buy == 3)
        {
            Small_home_1_6_prefab.SetActive(true);
            Button_Small_home_1_6_buy_1.SetActive(false);
            Button_Small_home_1_7_buy_1.SetActive(true);
        } 

        int Small_home_1_7_buy = PlayerPrefs.GetInt("Small_home_1_7_buy");
        if (Small_home_1_7_buy == 2 || Small_home_1_7_buy == 3)
        {
            Small_home_1_7_prefab.SetActive(true);
            Button_Small_home_1_7_buy_1.SetActive(false);
            Button_Small_home_1_8_buy_1.SetActive(true);
        } 

        int Small_home_1_8_buy = PlayerPrefs.GetInt("Small_home_1_8_buy");
        if (Small_home_1_8_buy == 2 || Small_home_1_8_buy == 3)
        {
            Small_home_1_8_prefab.SetActive(true);
            Button_Small_home_1_8_buy_1.SetActive(false);
            Button_Small_home_1_9_buy_1.SetActive(true);
        } 

        int Small_home_1_9_buy = PlayerPrefs.GetInt("Small_home_1_9_buy");
        if (Small_home_1_9_buy == 2 || Small_home_1_9_buy == 3)
        {
            Small_home_1_9_prefab.SetActive(true);
            Button_Small_home_1_9_buy_1.SetActive(false);
            Button_Small_home_1_10_buy_1.SetActive(true);
        } 

        int Small_home_1_10_buy = PlayerPrefs.GetInt("Small_home_1_10_buy");
        if (Small_home_1_10_buy == 2 || Small_home_1_10_buy == 3)
        {
            Small_home_1_10_prefab.SetActive(true);
            Button_Small_home_1_10_buy_1.SetActive(false);
            Button_Small_home_1_11_buy_1.SetActive(true);
        } 

        int Small_home_1_11_buy = PlayerPrefs.GetInt("Small_home_1_11_buy");
        if (Small_home_1_11_buy == 2 || Small_home_1_11_buy == 3)
        {
            Small_home_1_11_prefab.SetActive(true);
            Button_Small_home_1_11_buy_1.SetActive(false);
            Button_Small_home_1_12_buy_1.SetActive(true);
        } 

        int Small_home_1_12_buy = PlayerPrefs.GetInt("Small_home_1_12_buy");
        if (Small_home_1_12_buy == 2 || Small_home_1_12_buy == 3)
        {
            Small_home_1_12_prefab.SetActive(true);
            Button_Small_home_1_12_buy_1.SetActive(false);
            Button_Small_home_1_12_buy_2.SetActive(true);
        } 
    


        int Small_home_2_1_buy = PlayerPrefs.GetInt("Small_home_2_1_buy");
        if (Small_home_2_1_buy == 2 || Small_home_2_1_buy == 3)
        {
            Small_home_1_1_prefab.SetActive(false);
            Small_home_2_1_prefab.SetActive(true);
        }  

        int Small_home_2_2_buy = PlayerPrefs.GetInt("Small_home_2_2_buy");
        if (Small_home_2_2_buy == 2 || Small_home_2_2_buy == 3)
        {
            Small_home_1_2_prefab.SetActive(false);
            Small_home_2_2_prefab.SetActive(true);
        }

        int Small_home_2_3_buy = PlayerPrefs.GetInt("Small_home_2_3_buy");
        if (Small_home_2_3_buy == 2 || Small_home_2_3_buy == 3)
        {
            Small_home_1_3_prefab.SetActive(false);
            Small_home_2_3_prefab.SetActive(true);
        } 

        int Small_home_2_4_buy = PlayerPrefs.GetInt("Small_home_2_4_buy");
        if (Small_home_2_4_buy == 2 || Small_home_2_4_buy == 3)
        {
            Small_home_1_4_prefab.SetActive(false);
            Small_home_2_4_prefab.SetActive(true);
        } 

        int Small_home_2_5_buy = PlayerPrefs.GetInt("Small_home_2_5_buy");
        if (Small_home_2_5_buy == 2 || Small_home_2_5_buy == 3)
        {
            Small_home_1_5_prefab.SetActive(false);
            Small_home_2_5_prefab.SetActive(true);
        } 

        int Small_home_2_6_buy = PlayerPrefs.GetInt("Small_home_2_6_buy");
        if (Small_home_2_6_buy == 2 || Small_home_2_6_buy == 3)
        {
            Small_home_1_6_prefab.SetActive(false);
            Small_home_2_6_prefab.SetActive(true);
        } 

        int Small_home_2_7_buy = PlayerPrefs.GetInt("Small_home_2_7_buy");
        if (Small_home_2_7_buy == 2 || Small_home_2_7_buy == 3)
        {
            Small_home_1_7_prefab.SetActive(false);
            Small_home_2_7_prefab.SetActive(true);
        } 

        int Small_home_2_8_buy = PlayerPrefs.GetInt("Small_home_2_8_buy");
        if (Small_home_2_8_buy == 2 || Small_home_2_8_buy == 3)
        {
            Small_home_1_8_prefab.SetActive(false);
            Small_home_2_8_prefab.SetActive(true);
        } 

        int Small_home_2_9_buy = PlayerPrefs.GetInt("Small_home_2_9_buy");
        if (Small_home_2_9_buy == 2 || Small_home_2_9_buy == 3)
        {
            Small_home_1_9_prefab.SetActive(false);
            Small_home_2_9_prefab.SetActive(true);
        } 

        int Small_home_2_10_buy = PlayerPrefs.GetInt("Small_home_2_10_buy");
        if (Small_home_2_10_buy == 2 || Small_home_2_10_buy == 3)
        {
            Small_home_1_10_prefab.SetActive(false);
            Small_home_2_10_prefab.SetActive(true);
        } 

        int Small_home_2_11_buy = PlayerPrefs.GetInt("Small_home_2_11_buy");
        if (Small_home_2_11_buy == 2 || Small_home_2_11_buy == 3)
        {
            Small_home_1_11_prefab.SetActive(false);
            Small_home_2_11_prefab.SetActive(true);
        } 

        int Small_home_2_12_buy = PlayerPrefs.GetInt("Small_home_2_12_buy");
        if (Small_home_2_12_buy == 2 || Small_home_2_12_buy == 3)
        {
            Small_home_1_12_prefab.SetActive(false);
            Small_home_2_12_prefab.SetActive(true);
        } 


        int Small_home_3_1_buy = PlayerPrefs.GetInt("Small_home_3_1_buy");
        if (Small_home_3_1_buy == 2)
        {
            Small_home_2_1_prefab.SetActive(false);
            Small_home_3_1_prefab.SetActive(true);
        }  

        int Small_home_3_2_buy = PlayerPrefs.GetInt("Small_home_3_2_buy");
        if (Small_home_3_2_buy == 2)
        {
            Small_home_2_2_prefab.SetActive(false);
            Small_home_3_2_prefab.SetActive(true);
        }

        int Small_home_3_3_buy = PlayerPrefs.GetInt("Small_home_3_3_buy");
        if (Small_home_3_3_buy == 2)
        {
            Small_home_2_3_prefab.SetActive(false);
            Small_home_3_3_prefab.SetActive(true);
        } 

        int Small_home_3_4_buy = PlayerPrefs.GetInt("Small_home_3_4_buy");
        if (Small_home_3_4_buy == 2)
        {
            Small_home_2_4_prefab.SetActive(false);
            Small_home_3_4_prefab.SetActive(true);
        } 

        int Small_home_3_5_buy = PlayerPrefs.GetInt("Small_home_3_5_buy");
        if (Small_home_3_5_buy == 2)
        {
            Small_home_2_5_prefab.SetActive(false);
            Small_home_3_5_prefab.SetActive(true);
        } 

        int Small_home_3_6_buy = PlayerPrefs.GetInt("Small_home_3_6_buy");
        if (Small_home_3_6_buy == 2)
        {
            Small_home_2_6_prefab.SetActive(false);
            Small_home_3_6_prefab.SetActive(true);
        } 

        int Small_home_3_7_buy = PlayerPrefs.GetInt("Small_home_3_7_buy");
        if (Small_home_3_7_buy == 2)
        {
            Small_home_2_7_prefab.SetActive(false);
            Small_home_3_7_prefab.SetActive(true);
        } 

        int Small_home_3_8_buy = PlayerPrefs.GetInt("Small_home_3_8_buy");
        if (Small_home_3_8_buy == 2)
        {
            Small_home_2_8_prefab.SetActive(false);
            Small_home_3_8_prefab.SetActive(true);
        } 

        int Small_home_3_9_buy = PlayerPrefs.GetInt("Small_home_3_9_buy");
        if (Small_home_3_9_buy == 2)
        {
            Small_home_2_9_prefab.SetActive(false);
            Small_home_3_9_prefab.SetActive(true);
        }

        int Small_home_3_10_buy = PlayerPrefs.GetInt("Small_home_3_10_buy");
        if (Small_home_3_10_buy == 2)
        {
            Small_home_2_10_prefab.SetActive(false);
            Small_home_3_10_prefab.SetActive(true);
        } 

        int Small_home_3_11_buy = PlayerPrefs.GetInt("Small_home_3_11_buy");
        if (Small_home_3_11_buy == 2)
        {
            Small_home_2_11_prefab.SetActive(false);
            Small_home_3_11_prefab.SetActive(true);
        } 

        int Small_home_3_12_buy = PlayerPrefs.GetInt("Small_home_3_12_buy");
        if (Small_home_3_12_buy == 2)
        {
            Small_home_2_12_prefab.SetActive(false);
            Small_home_3_12_prefab.SetActive(true);
        }


    }

    void Update()
    {

        int loadsum = PlayerPrefs.GetInt("summ");
        summ = loadsum;
        textSum.text = summ.ToString();

        int loadbriliant = PlayerPrefs.GetInt("briliant");
        briliant = loadbriliant;
        textBriliant.text = briliant.ToString();

        int Small_home_1_1_load = PlayerPrefs.GetInt("Small_home_1_1_buy");
        Small_home_1_1_buy = Small_home_1_1_load;
        if(Small_home_1_1_buy == 2)
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

        int Small_home_1_2_load = PlayerPrefs.GetInt("Small_home_1_2_buy");
        Small_home_1_2_buy = Small_home_1_2_load;
        if(Small_home_1_2_buy == 2)
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

        int Small_home_1_3_load = PlayerPrefs.GetInt("Small_home_1_3_buy");
        Small_home_1_3_buy = Small_home_1_3_load;
        if(Small_home_1_3_buy == 2)
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

        int Small_home_1_4_load = PlayerPrefs.GetInt("Small_home_1_4_buy");
        Small_home_1_4_buy = Small_home_1_4_load;
        if(Small_home_1_4_buy == 2)
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

        int Small_home_1_5_load = PlayerPrefs.GetInt("Small_home_1_5_buy");
        Small_home_1_5_buy = Small_home_1_5_load;
        if(Small_home_1_5_buy == 2)
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

        int Small_home_1_6_load = PlayerPrefs.GetInt("Small_home_1_6_buy");
        Small_home_1_6_buy = Small_home_1_6_load;
        if(Small_home_1_6_buy == 2)
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

        int Small_home_1_7_load = PlayerPrefs.GetInt("Small_home_1_7_buy");
        Small_home_1_7_buy = Small_home_1_7_load;
        if(Small_home_1_7_buy == 2)
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

        int Small_home_1_8_load = PlayerPrefs.GetInt("Small_home_1_8_buy");
        Small_home_1_8_buy = Small_home_1_8_load;
        if(Small_home_1_8_buy == 2)
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

        int Small_home_1_9_load = PlayerPrefs.GetInt("Small_home_1_9_buy");
        Small_home_1_9_buy = Small_home_1_9_load;
        if(Small_home_1_9_buy == 2)
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

        int Small_home_1_10_load = PlayerPrefs.GetInt("Small_home_1_10_buy");
        Small_home_1_10_buy = Small_home_1_10_load;
        if(Small_home_1_10_buy == 2)
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

        int Small_home_1_11_load = PlayerPrefs.GetInt("Small_home_1_11_buy");
        Small_home_1_11_buy = Small_home_1_11_load;
        if(Small_home_1_11_buy == 2)
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

        int Small_home_1_12_load = PlayerPrefs.GetInt("Small_home_1_12_buy");
        Small_home_1_12_buy = Small_home_1_12_load;
        if(Small_home_1_12_buy == 2)
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
        int Small_home_2_1_load = PlayerPrefs.GetInt("Small_home_2_1_buy");
        Small_home_2_1_buy = Small_home_2_1_load;
        if(Small_home_2_1_buy == 2)
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

        int Small_home_2_2_load = PlayerPrefs.GetInt("Small_home_2_2_buy");
        Small_home_2_2_buy = Small_home_2_2_load;
        if(Small_home_2_2_buy == 2)
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

        int Small_home_2_3_load = PlayerPrefs.GetInt("Small_home_2_3_buy");
        Small_home_2_3_buy = Small_home_2_3_load;
        if(Small_home_2_3_buy == 2)
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

        int Small_home_2_4_load = PlayerPrefs.GetInt("Small_home_2_4_buy");
        Small_home_2_4_buy = Small_home_2_4_load;
        if(Small_home_2_4_buy == 2)
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

        int Small_home_2_5_load = PlayerPrefs.GetInt("Small_home_2_5_buy");
        Small_home_2_5_buy = Small_home_2_5_load;
        if(Small_home_2_5_buy == 2)
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

        int Small_home_2_6_load = PlayerPrefs.GetInt("Small_home_2_6_buy");
        Small_home_2_6_buy = Small_home_2_6_load;
        if(Small_home_2_6_buy == 2)
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

        int Small_home_2_7_load = PlayerPrefs.GetInt("Small_home_2_7_buy");
        Small_home_2_7_buy = Small_home_2_7_load;
        if(Small_home_2_7_buy == 2)
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

        int Small_home_2_8_load = PlayerPrefs.GetInt("Small_home_2_8_buy");
        Small_home_2_8_buy = Small_home_2_8_load;
        if(Small_home_2_8_buy == 2)
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

        int Small_home_2_9_load = PlayerPrefs.GetInt("Small_home_2_9_buy");
        Small_home_2_9_buy = Small_home_2_9_load;
        if(Small_home_2_9_buy == 2)
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
                int Small_home_2_10_load = PlayerPrefs.GetInt("Small_home_2_10_buy");
        Small_home_2_10_buy = Small_home_2_10_load;
        if(Small_home_2_10_buy == 2)
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

        int Small_home_2_11_load = PlayerPrefs.GetInt("Small_home_2_11_buy");
        Small_home_2_11_buy = Small_home_2_11_load;
        if(Small_home_2_11_buy == 2)
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

        int Small_home_2_12_load = PlayerPrefs.GetInt("Small_home_2_12_buy");
        Small_home_2_12_buy = Small_home_2_12_load;
        if(Small_home_2_12_buy == 2)
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

        int Small_home_3_1_load = PlayerPrefs.GetInt("Small_home_3_1_buy");
        Small_home_3_1_buy = Small_home_3_1_load;
        if(Small_home_3_1_buy == 2)
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

        int Small_home_3_2_load = PlayerPrefs.GetInt("Small_home_3_2_buy");
        Small_home_3_2_buy = Small_home_3_2_load;
        if(Small_home_3_2_buy == 2)
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

        int Small_home_3_3_load = PlayerPrefs.GetInt("Small_home_3_3_buy");
        Small_home_3_3_buy = Small_home_3_3_load;
        if(Small_home_3_3_buy == 2)
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

        int Small_home_3_4_load = PlayerPrefs.GetInt("Small_home_3_4_buy");
        Small_home_3_4_buy = Small_home_3_4_load;
        if(Small_home_3_4_buy == 2)
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

        int Small_home_3_5_load = PlayerPrefs.GetInt("Small_home_3_5_buy");
        Small_home_3_5_buy = Small_home_3_5_load;
        if(Small_home_3_5_buy == 2)
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

        int Small_home_3_6_load = PlayerPrefs.GetInt("Small_home_3_6_buy");
        Small_home_3_6_buy = Small_home_3_6_load;
        if(Small_home_3_6_buy == 2)
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

        int Small_home_3_7_load = PlayerPrefs.GetInt("Small_home_3_7_buy");
        Small_home_3_7_buy = Small_home_3_7_load;
        if(Small_home_3_7_buy == 2)
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

        int Small_home_3_8_load = PlayerPrefs.GetInt("Small_home_3_8_buy");
        Small_home_3_8_buy = Small_home_3_8_load;
        if(Small_home_3_8_buy == 2)
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

        int Small_home_3_9_load = PlayerPrefs.GetInt("Small_home_3_9_buy");
        Small_home_3_9_buy = Small_home_3_9_load;
        if(Small_home_3_9_buy == 2)
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

        int Small_home_3_10_load = PlayerPrefs.GetInt("Small_home_3_10_buy");
        Small_home_3_10_buy = Small_home_3_10_load;
        if(Small_home_3_10_buy == 2)
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

        int Small_home_3_11_load = PlayerPrefs.GetInt("Small_home_3_11_buy");
        Small_home_3_11_buy = Small_home_3_11_load;
        if(Small_home_3_11_buy == 2)
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

        int Small_home_3_12_load = PlayerPrefs.GetInt("Small_home_3_12_buy");
        Small_home_3_12_buy = Small_home_3_12_load;
        if(Small_home_3_12_buy == 2)
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
    public void CloseSmall_home_1_1()
    {
        Small_home_1_1_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_1_2()
    {
        Small_home_1_2_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_1_3()
    {
        Small_home_1_3_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_1_4()
    {
        Small_home_1_4_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_1_5()
    {
        Small_home_1_5_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_1_6()
    {
        Small_home_1_6_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_1_7()
    {
        Small_home_1_7_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_1_8()
    {
        Small_home_1_8_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_1_9()
    {
        Small_home_1_9_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_1_10()
    {
        Small_home_1_10_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_1_11()
    {
        Small_home_1_11_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_1_12()
    {
        Small_home_1_12_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }

    public void CloseSmall_home_2_1()
    {
        Small_home_2_1_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_2_2()
    {
        Small_home_2_2_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_2_3()
    {
        Small_home_2_3_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_2_4()
    {
        Small_home_2_4_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_2_5()
    {
        Small_home_2_5_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_2_6()
    {
        Small_home_2_6_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_2_7()
    {
        Small_home_2_7_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_2_8()
    {
        Small_home_2_8_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_2_9()
    {
        Small_home_2_9_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_2_10()
    {
        Small_home_2_10_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_2_11()
    {
        Small_home_2_11_panel.SetActive(false);        
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_2_12()
    {
        Small_home_2_12_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_3_1()
    {
        Small_home_3_1_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_3_2()
    {
        Small_home_3_2_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_3_3()
    {
        Small_home_3_3_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_3_4()
    {
        Small_home_3_4_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_3_5()
    {
        Small_home_3_5_panel.SetActive(false);        
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_3_6()
    {
        Small_home_3_6_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_3_7()
    {
        Small_home_3_7_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_3_8()
    {
        Small_home_3_8_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_3_9()
    {
        Small_home_3_9_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
        public void CloseSmall_home_3_10()
    {
        Small_home_3_10_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_3_11()
    {
        Small_home_3_11_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }
    public void CloseSmall_home_3_12()
    {
        Small_home_3_12_panel.SetActive(false);
        panelBox.SetActive(false);
        sales.SetActive(false);
    }

    public void BuyStoreSmall_home_1_1()
    {
        nameBuy = "Small_home_1_1";
        BuyStore();
    }
    public void BuyStoreSmall_home_1_2()
    {
        nameBuy = "Small_home_1_2";
        BuyStore();
    }
    public void BuyStoreSmall_home_1_3()
    {
        nameBuy = "Small_home_1_3";
        BuyStore();
    }
    public void BuyStoreSmall_home_1_4()
    {
        nameBuy = "Small_home_1_4";
        BuyStore();
    }
    public void BuyStoreSmall_home_1_5()
    {
        nameBuy = "Small_home_1_5";
        BuyStore();
    }
    public void BuyStoreSmall_home_1_6()
    {
        nameBuy = "Small_home_1_6";
        BuyStore();
    }
    public void BuyStoreSmall_home_1_7()
    {
        nameBuy = "Small_home_1_7";
        BuyStore();
    }
    public void BuyStoreSmall_home_1_8()
    {
        nameBuy = "Small_home_1_8";
        BuyStore();
    }
    public void BuyStoreSmall_home_1_9()
    {
        nameBuy = "Small_home_1_9";
        BuyStore();
    }
    public void BuyStoreSmall_home_1_10()
    {
        nameBuy = "Small_home_1_10";
        BuyStore();
    }
    public void BuyStoreSmall_home_1_11()
    {
        nameBuy = "Small_home_1_11";
        BuyStore();
    }
    public void BuyStoreSmall_home_1_12()
    {
        nameBuy = "Small_home_1_12";
        BuyStore();
    }

    public void BuyStoreSmall_home_2_1()
    {
        nameBuy = "Small_home_2_1";
        BuyStore();
    }
    public void BuyStoreSmall_home_2_2()
    {
        nameBuy = "Small_home_2_2";
        BuyStore();
    }
    public void BuyStoreSmall_home_2_3()
    {
        nameBuy = "Small_home_2_3";
        BuyStore();
    }
    public void BuyStoreSmall_home_2_4()
    {
        nameBuy = "Small_home_2_4";
        BuyStore();
    }
    public void BuyStoreSmall_home_2_5()
    {
        nameBuy = "Small_home_2_5";
        BuyStore();
    }
    public void BuyStoreSmall_home_2_6()
    {
        nameBuy = "Small_home_2_6";
        BuyStore();
    }
    public void BuyStoreSmall_home_2_7()
    {
        nameBuy = "Small_home_2_7";
        BuyStore();
    }
    public void BuyStoreSmall_home_2_8()
    {
        nameBuy = "Small_home_2_8";
        BuyStore();
    }
    public void BuyStoreSmall_home_2_9()
    {
        nameBuy = "Small_home_2_9";
        BuyStore();
    }
    public void BuyStoreSmall_home_2_10()
    {
        nameBuy = "Small_home_2_10";
        BuyStore();
    }
    public void BuyStoreSmall_home_2_11()
    {
        nameBuy = "Small_home_2_11";
        BuyStore();
    }
    public void BuyStoreSmall_home_2_12()
    {
        nameBuy = "Small_home_2_12";
        BuyStore();
    }

    public void BuyStoreSmall_home_3_1()
    {
        nameBuy = "Small_home_3_1";
        BuyStore();
    }
    public void BuyStoreSmall_home_3_2()
    {
        nameBuy = "Small_home_3_2";
        BuyStore();
    }
    public void BuyStoreSmall_home_3_3()
    {
        nameBuy = "Small_home_3_3";
        BuyStore();
    }
    public void BuyStoreSmall_home_3_4()
    {
        nameBuy = "Small_home_3_4";
        BuyStore();
    }
    public void BuyStoreSmall_home_3_5()
    {
        nameBuy = "Small_home_3_5";
        BuyStore();
    }
    public void BuyStoreSmall_home_3_6()
    {
        nameBuy = "Small_home_3_6";
        BuyStore();
    }
    public void BuyStoreSmall_home_3_7()
    {
        nameBuy = "Small_home_3_7";
        BuyStore();
    }
    public void BuyStoreSmall_home_3_8()
    {
        nameBuy = "Small_home_3_8";
        BuyStore();
    }
    public void BuyStoreSmall_home_3_9()
    {
        nameBuy = "Small_home_3_9";
        BuyStore();
    }
    public void BuyStoreSmall_home_3_10()
    {
        nameBuy = "Small_home_3_10";
        BuyStore();
    }
    public void BuyStoreSmall_home_3_11()
    {
        nameBuy = "Small_home_3_11";
        BuyStore();
    }
    public void BuyStoreSmall_home_3_12()
    {
        nameBuy = "Small_home_3_12";
        BuyStore();
    }

    public void BuyStore()
    {
    if (nameBuy == "Small_home_1_1" && summ >= 200)
        {
            if (Small_home_1_1_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_1_1";
                    price = 200;
                    StartCoroutine(BuyProduct());
                    summ-=200;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_1_1_buy = 2;
                    PlayerPrefs.SetInt("Small_home_1_1_buy", Small_home_1_1_buy);
                    PlayerPrefs.Save();
                    Small_home_1_1_prefab.SetActive(true);
                    Button_Small_home_1_1_buy_1.SetActive(false);
                    Button_Small_home_1_2_buy_1.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_1_2" && summ >= 200)
        {
            if (Small_home_1_2_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_1_2";
                    price = 200;
                    StartCoroutine(BuyProduct());
                    summ-=200;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_1_2_buy = 2;
                    PlayerPrefs.SetInt("Small_home_1_2_buy", Small_home_1_2_buy);
                    PlayerPrefs.Save();
                    Small_home_1_2_prefab.SetActive(true);
                    Button_Small_home_1_2_buy_1.SetActive(false);
                    Button_Small_home_1_3_buy_1.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_1_3" && summ >= 200)
        {
            if (Small_home_1_3_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_1_3";
                    price = 200;
                    StartCoroutine(BuyProduct());
                    summ-=200;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_1_3_buy = 2;
                    PlayerPrefs.SetInt("Small_home_1_3_buy", Small_home_1_3_buy);
                    PlayerPrefs.Save();
                    Small_home_1_3_prefab.SetActive(true);
                    Button_Small_home_1_3_buy_1.SetActive(false);
                    Button_Small_home_1_4_buy_1.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_1_4" && summ >= 200)
        {
            if (Small_home_1_4_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_1_4";
                    price = 200;
                    StartCoroutine(BuyProduct());
                    summ-=200;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_1_4_buy = 2;
                    PlayerPrefs.SetInt("Small_home_1_4_buy", Small_home_1_4_buy);
                    PlayerPrefs.Save();
                    Small_home_1_4_prefab.SetActive(true);
                    Button_Small_home_1_4_buy_1.SetActive(false);
                    Button_Small_home_1_5_buy_1.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_1_5" && summ >= 200)
        {
            if (Small_home_1_5_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_1_5";
                    price = 200;
                    StartCoroutine(BuyProduct());
                    summ-=200;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_1_5_buy = 2;
                    PlayerPrefs.SetInt("Small_home_1_5_buy", Small_home_1_5_buy);
                    PlayerPrefs.Save();
                    Small_home_1_5_prefab.SetActive(true);
                    Button_Small_home_1_5_buy_1.SetActive(false);
                    Button_Small_home_1_6_buy_1.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_1_6" && summ >= 200)
        {
            if (Small_home_1_6_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_1_6";
                    price = 200;
                    StartCoroutine(BuyProduct());
                    summ-=200;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_1_6_buy = 2;
                    PlayerPrefs.SetInt("Small_home_1_6_buy", Small_home_1_6_buy);
                    PlayerPrefs.Save();
                    Small_home_1_6_prefab.SetActive(true);
                    Button_Small_home_1_6_buy_1.SetActive(false);
                    Button_Small_home_1_7_buy_1.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_1_7" && summ >= 200)
        {
            if (Small_home_1_7_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_1_7";
                    price = 200;
                    StartCoroutine(BuyProduct());
                    summ-=200;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_1_7_buy = 2;
                    PlayerPrefs.SetInt("Small_home_1_7_buy", Small_home_1_7_buy);
                    PlayerPrefs.Save();
                    Small_home_1_7_prefab.SetActive(true);
                    Button_Small_home_1_7_buy_1.SetActive(false);
                    Button_Small_home_1_8_buy_1.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_1_8" && summ >= 200)
        {
            if (Small_home_1_8_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_1_8";
                    price = 200;
                    StartCoroutine(BuyProduct());
                    summ-=200;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_1_8_buy = 2;
                    PlayerPrefs.SetInt("Small_home_1_8_buy", Small_home_1_8_buy);
                    PlayerPrefs.Save();
                    Small_home_1_8_prefab.SetActive(true);
                    Button_Small_home_1_8_buy_1.SetActive(false);
                    Button_Small_home_1_9_buy_1.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_1_9" && summ >= 200)
        {
            if (Small_home_1_9_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_1_9";
                    price = 200;
                    StartCoroutine(BuyProduct());
                    summ-=200;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_1_9_buy = 2;
                    PlayerPrefs.SetInt("Small_home_1_9_buy", Small_home_1_9_buy);
                    PlayerPrefs.Save();
                    Small_home_1_9_prefab.SetActive(true);
                    Button_Small_home_1_9_buy_1.SetActive(false);
                    Button_Small_home_1_10_buy_1.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_1_10" && summ >= 200)
        {
            if (Small_home_1_10_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_1_10";
                    price = 200;
                    StartCoroutine(BuyProduct());
                    summ-=200;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_1_10_buy = 2;
                    PlayerPrefs.SetInt("Small_home_1_10_buy", Small_home_1_10_buy);
                    PlayerPrefs.Save();
                    Small_home_1_10_prefab.SetActive(true);
                    Button_Small_home_1_10_buy_1.SetActive(false);
                    Button_Small_home_1_11_buy_1.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_1_11" && summ >= 200)
        {
            if (Small_home_1_11_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_1_11";
                    price = 200;
                    StartCoroutine(BuyProduct());
                    summ-=200;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_1_11_buy = 2;
                    PlayerPrefs.SetInt("Small_home_1_11_buy", Small_home_1_11_buy);
                    PlayerPrefs.Save();
                    Small_home_1_11_prefab.SetActive(true);
                    Button_Small_home_1_11_buy_1.SetActive(false);
                    Button_Small_home_1_12_buy_1.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_1_12" && summ >= 200)
        {
            if (Small_home_1_12_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_1_12";
                    price = 200;
                    StartCoroutine(BuyProduct());
                    summ-=200;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_1_12_buy = 2;
                    PlayerPrefs.SetInt("Small_home_1_12_buy", Small_home_1_12_buy);
                    PlayerPrefs.Save();
                    Small_home_1_12_prefab.SetActive(true);
                    Button_Small_home_1_12_buy_1.SetActive(false);
                    Button_Small_home_1_12_buy_2.SetActive(true);
                }
        }

    else if (nameBuy == "Small_home_2_1" && summ >= 350)
        {
            if (Small_home_2_1_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_2_1";
                    price = 350;
                    StartCoroutine(BuyProduct());
                    summ-=350;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_2_1_buy = 2;
                    Small_home_1_1_buy = 3;
                    PlayerPrefs.SetInt("Small_home_2_1_buy", Small_home_2_1_buy);
                    PlayerPrefs.SetInt("Small_home_1_1_buy", Small_home_1_1_buy);
                    PlayerPrefs.Save();
                    Small_home_1_1_prefab.SetActive(false);
                    Small_home_2_1_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_2_2" && summ >= 350)
        {
            if (Small_home_2_2_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_2_2";
                    price = 350;
                    StartCoroutine(BuyProduct());
                    summ-=350;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_2_2_buy = 2;
                    Small_home_1_2_buy = 3;
                    PlayerPrefs.SetInt("Small_home_2_2_buy", Small_home_2_2_buy);
                    PlayerPrefs.SetInt("Small_home_1_2_buy", Small_home_1_2_buy);
                    PlayerPrefs.Save();
                    Small_home_1_2_prefab.SetActive(false);
                    Small_home_2_2_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_2_3" && summ >= 350)
        {
            if (Small_home_2_3_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_2_3";
                    price = 350;
                    StartCoroutine(BuyProduct());
                    summ-=350;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_2_3_buy = 2;
                    Small_home_1_3_buy = 3;
                    PlayerPrefs.SetInt("Small_home_2_3_buy", Small_home_2_3_buy);
                    PlayerPrefs.SetInt("Small_home_1_3_buy", Small_home_1_3_buy);
                    PlayerPrefs.Save();
                    Small_home_1_3_prefab.SetActive(false);
                    Small_home_2_3_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_2_4" && summ >= 350)
        {
            if (Small_home_2_4_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_2_4";
                    price = 350;
                    StartCoroutine(BuyProduct());
                    summ-=350;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_2_4_buy = 2;
                    Small_home_1_4_buy = 3;
                    PlayerPrefs.SetInt("Small_home_2_4_buy", Small_home_2_4_buy);
                    PlayerPrefs.SetInt("Small_home_1_4_buy", Small_home_1_4_buy);
                    PlayerPrefs.Save();
                    Small_home_1_4_prefab.SetActive(false);
                    Small_home_2_4_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_2_5" && summ >= 350)
        {
            if (Small_home_2_5_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_2_5";
                    price = 350;
                    StartCoroutine(BuyProduct());
                    summ-=350;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_2_5_buy = 2;
                    Small_home_1_5_buy = 3;
                    PlayerPrefs.SetInt("Small_home_2_5_buy", Small_home_2_5_buy);
                    PlayerPrefs.SetInt("Small_home_1_5_buy", Small_home_1_5_buy);
                    PlayerPrefs.Save();
                    Small_home_1_5_prefab.SetActive(false);
                    Small_home_2_5_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_2_6" && summ >= 350)
        {
            if (Small_home_2_6_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_2_6";
                    price = 350;
                    StartCoroutine(BuyProduct());
                    summ-=350;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_2_6_buy = 2;
                    Small_home_1_6_buy = 3;
                    PlayerPrefs.SetInt("Small_home_2_6_buy", Small_home_2_6_buy);
                    PlayerPrefs.SetInt("Small_home_1_6_buy", Small_home_1_6_buy);
                    PlayerPrefs.Save();
                    Small_home_1_6_prefab.SetActive(false);
                    Small_home_2_6_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_2_7" && summ >= 350)
        {
            if (Small_home_2_7_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_2_7";
                    price = 350;
                    StartCoroutine(BuyProduct());
                    summ-=350;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_2_7_buy = 2;
                    Small_home_1_7_buy = 3;
                    PlayerPrefs.SetInt("Small_home_2_7_buy", Small_home_2_7_buy);
                    PlayerPrefs.SetInt("Small_home_1_7_buy", Small_home_1_7_buy);
                    PlayerPrefs.Save();
                    Small_home_1_7_prefab.SetActive(false);
                    Small_home_2_7_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_2_8" && summ >= 350)
        {
            if (Small_home_2_8_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_2_8";
                    price = 350;
                    StartCoroutine(BuyProduct());
                    summ-=350;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_2_8_buy = 2;
                    Small_home_1_8_buy = 3;
                    PlayerPrefs.SetInt("Small_home_2_8_buy", Small_home_2_8_buy);
                    PlayerPrefs.SetInt("Small_home_1_8_buy", Small_home_1_8_buy);
                    PlayerPrefs.Save();
                    Small_home_1_8_prefab.SetActive(false);
                    Small_home_2_8_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_2_9" && summ >= 350)
        {
            if (Small_home_2_9_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_2_9";
                    price = 350;
                    StartCoroutine(BuyProduct());
                    summ-=350;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_2_9_buy = 2;
                    Small_home_1_9_buy = 3;
                    PlayerPrefs.SetInt("Small_home_2_9_buy", Small_home_2_9_buy);
                    PlayerPrefs.SetInt("Small_home_1_9_buy", Small_home_1_9_buy);
                    PlayerPrefs.Save();
                    Small_home_1_9_prefab.SetActive(false);
                    Small_home_2_9_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_2_10" && summ >= 350)
        {
            if (Small_home_2_10_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_2_10";
                    price = 350;
                    StartCoroutine(BuyProduct());
                    summ-=350;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_2_10_buy = 2;
                    Small_home_1_10_buy = 3;
                    PlayerPrefs.SetInt("Small_home_2_10_buy", Small_home_2_10_buy);
                    PlayerPrefs.SetInt("Small_home_1_10_buy", Small_home_1_10_buy);
                    PlayerPrefs.Save();
                    Small_home_1_10_prefab.SetActive(false);
                    Small_home_2_10_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_2_11" && summ >= 350)
        {
            if (Small_home_2_11_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_2_11";
                    price = 350;
                    StartCoroutine(BuyProduct());
                    summ-=350;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_2_11_buy = 2;
                    Small_home_1_11_buy = 3;
                    PlayerPrefs.SetInt("Small_home_2_11_buy", Small_home_2_11_buy);
                    PlayerPrefs.SetInt("Small_home_1_11_buy", Small_home_1_11_buy);
                    PlayerPrefs.Save();
                    Small_home_1_11_prefab.SetActive(false);
                    Small_home_2_11_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_2_12" && summ >= 350)
        {
            if (Small_home_2_12_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_2_12";
                    price = 350;
                    StartCoroutine(BuyProduct());
                    summ-=350;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_2_12_buy = 2;
                    Small_home_1_12_buy = 3;
                    PlayerPrefs.SetInt("Small_home_2_12_buy", Small_home_2_12_buy);
                    PlayerPrefs.SetInt("Small_home_1_12_buy", Small_home_1_12_buy);
                    PlayerPrefs.Save();
                    Small_home_1_12_prefab.SetActive(false);
                    Small_home_2_12_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_3_1" && summ >= 500)
        {
            if (Small_home_3_1_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_3_2";
                    price = 500;
                    StartCoroutine(BuyProduct());
                    summ-=500;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_3_1_buy = 2;
                    Small_home_2_1_buy = 3;
                    PlayerPrefs.SetInt("Small_home_3_1_buy", Small_home_3_1_buy);
                    PlayerPrefs.SetInt("Small_home_2_1_buy", Small_home_2_1_buy);
                    PlayerPrefs.Save();
                    Small_home_2_1_prefab.SetActive(false);
                    Small_home_3_1_prefab.SetActive(true);
                }
        }

    else if (nameBuy == "Small_home_3_2" && summ >= 500)
        {
            if (Small_home_3_2_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_3_2";
                    price = 500;
                    StartCoroutine(BuyProduct());
                    summ-=500;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_3_2_buy = 2;
                    Small_home_2_2_buy = 3;
                    PlayerPrefs.SetInt("Small_home_3_2_buy", Small_home_3_2_buy);
                    PlayerPrefs.SetInt("Small_home_2_3_buy", Small_home_2_2_buy);
                    PlayerPrefs.Save();
                    Small_home_2_2_prefab.SetActive(false);
                    Small_home_3_2_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_3_3" && summ >= 500)
        {
            if (Small_home_3_3_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_3_3";
                    price = 500;
                    StartCoroutine(BuyProduct());
                    summ-=500;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_3_3_buy = 2;
                    Small_home_2_3_buy = 3;
                    PlayerPrefs.SetInt("Small_home_3_3_buy", Small_home_3_3_buy);
                    PlayerPrefs.SetInt("Small_home_2_3_buy", Small_home_2_3_buy);
                    PlayerPrefs.Save();
                    Small_home_2_3_prefab.SetActive(false);
                    Small_home_3_3_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_3_4" && summ >= 500)
        {
            if (Small_home_3_4_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_3_4";
                    price = 500;
                    StartCoroutine(BuyProduct());
                    summ-=500;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_3_4_buy = 2;
                    Small_home_2_4_buy = 3;
                    PlayerPrefs.SetInt("Small_home_3_4_buy", Small_home_3_4_buy);
                    PlayerPrefs.SetInt("Small_home_2_4_buy", Small_home_2_4_buy);
                    PlayerPrefs.Save();
                    Small_home_2_4_prefab.SetActive(false);
                    Small_home_3_4_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_3_5" && summ >= 500)
        {
            if (Small_home_3_5_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_3_5";
                    price = 500;
                    StartCoroutine(BuyProduct());
                    summ-=500;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_3_5_buy = 2;
                    Small_home_2_5_buy = 3;
                    PlayerPrefs.SetInt("Small_home_3_5_buy", Small_home_3_5_buy);
                    PlayerPrefs.SetInt("Small_home_2_5_buy", Small_home_2_5_buy);
                    PlayerPrefs.Save();
                    Small_home_2_5_prefab.SetActive(false);
                    Small_home_3_5_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_3_6" && summ >= 500)
        {
            if (Small_home_3_6_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_3_6";
                    price = 500;
                    StartCoroutine(BuyProduct());
                    summ-=500;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_3_6_buy = 2;
                    Small_home_2_6_buy = 3;
                    PlayerPrefs.SetInt("Small_home_3_6_buy", Small_home_3_6_buy);
                    PlayerPrefs.SetInt("Small_home_2_6_buy", Small_home_2_6_buy);
                    PlayerPrefs.Save();
                    Small_home_2_6_prefab.SetActive(false);
                    Small_home_3_6_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_3_7" && summ >= 500)
        {
            if (Small_home_3_7_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_3_7";
                    price = 500;
                    StartCoroutine(BuyProduct());
                    summ-=500;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_3_7_buy = 2;
                    Small_home_2_7_buy = 3;
                    PlayerPrefs.SetInt("Small_home_3_7_buy", Small_home_3_7_buy);
                    PlayerPrefs.SetInt("Small_home_2_7_buy", Small_home_2_7_buy);
                    PlayerPrefs.Save();
                    Small_home_2_7_prefab.SetActive(false);
                    Small_home_3_7_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_3_8" && summ >= 500)
        {
            if (Small_home_3_8_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_3_8";
                    price = 500;
                    StartCoroutine(BuyProduct());
                    summ-=500;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_3_8_buy = 2;
                    Small_home_2_8_buy = 3;
                    PlayerPrefs.SetInt("Small_home_3_8_buy", Small_home_3_8_buy);
                    PlayerPrefs.SetInt("Small_home_2_8_buy", Small_home_2_8_buy);
                    PlayerPrefs.Save();
                    Small_home_2_8_prefab.SetActive(false);
                    Small_home_3_8_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_3_9" && summ >= 500)
        {
            if (Small_home_3_9_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_3_9";
                    price = 500;
                    StartCoroutine(BuyProduct());
                    summ-=500;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_3_9_buy = 2;
                    Small_home_2_9_buy = 3;
                    PlayerPrefs.SetInt("Small_home_3_9_buy", Small_home_3_9_buy);
                    PlayerPrefs.SetInt("Small_home_2_9_buy", Small_home_2_9_buy);
                    PlayerPrefs.Save();
                    Small_home_2_9_prefab.SetActive(false);
                    Small_home_3_9_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_3_10" && summ >= 500)
        {
            if (Small_home_3_10_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_3_10";
                    price = 500;
                    StartCoroutine(BuyProduct());
                    summ-=500;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_3_10_buy = 2;
                    Small_home_2_10_buy = 3;
                    PlayerPrefs.SetInt("Small_home_3_10_buy", Small_home_3_10_buy);
                    PlayerPrefs.SetInt("Small_home_2_10_buy", Small_home_2_10_buy);
                    PlayerPrefs.Save();
                    Small_home_2_10_prefab.SetActive(false);
                    Small_home_3_10_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_3_11" && summ >= 500)
        {
            if (Small_home_3_11_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_3_11";
                    price = 500;
                    StartCoroutine(BuyProduct());
                    summ-=500;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_3_11_buy = 2;
                    Small_home_2_11_buy = 3;
                    PlayerPrefs.SetInt("Small_home_3_11_buy", Small_home_3_11_buy);
                    PlayerPrefs.SetInt("Small_home_2_11_buy", Small_home_2_11_buy);
                    PlayerPrefs.Save();
                    Small_home_2_11_prefab.SetActive(false);
                    Small_home_3_11_prefab.SetActive(true);
                }
        }
    else if (nameBuy == "Small_home_3_12" && summ >= 500)
        {
            if (Small_home_3_12_buy == 2) 
                {
                    sales.SetActive(true);
                }
            else
                {
                    string loadusers = PlayerPrefs.GetString("userid");
                    userid = loadusers;
                    nameprice = "Small_home_3_12";
                    price = 500;
                    StartCoroutine(BuyProduct());
                    summ-=500;
                    PlayerPrefs.SetInt("summ", summ);
                    Small_home_3_12_buy = 2;
                    Small_home_2_12_buy = 3;
                    PlayerPrefs.SetInt("Small_home_3_12_buy", Small_home_3_12_buy);
                    PlayerPrefs.SetInt("Small_home_2_12_buy", Small_home_2_12_buy);
                    PlayerPrefs.Save();
                    Small_home_2_12_prefab.SetActive(false);
                    Small_home_3_12_prefab.SetActive(true);
                }
        }
    else
        {
            panelBox.SetActive(true);
        }
        //int loadsum = PlayerPrefs.GetInt("summ");
        //summ = loadsum;
        //textSum.text = summ.ToString();
        int Small_home_1_1_load = PlayerPrefs.GetInt("Small_home_1_1_buy");
        Small_home_1_1_buy = Small_home_1_1_load;

        int Small_home_1_2_load = PlayerPrefs.GetInt("Small_home_1_2_buy");
        Small_home_1_2_buy = Small_home_1_2_load;

        int Small_home_1_3_load = PlayerPrefs.GetInt("Small_home_1_3_buy");
        Small_home_1_3_buy = Small_home_1_3_load;

        int Small_home_1_4_load = PlayerPrefs.GetInt("Small_home_1_4_buy");
        Small_home_1_4_buy = Small_home_1_4_load;

        int Small_home_1_5_load = PlayerPrefs.GetInt("Small_home_1_5_buy");
        Small_home_1_5_buy = Small_home_1_5_load;

        int Small_home_1_6_load = PlayerPrefs.GetInt("Small_home_1_6_buy");
        Small_home_1_6_buy = Small_home_1_6_load;

        int Small_home_1_7_load = PlayerPrefs.GetInt("Small_home_1_7_buy");
        Small_home_1_7_buy = Small_home_1_7_load;

        int Small_home_1_8_load = PlayerPrefs.GetInt("Small_home_1_8_buy");
        Small_home_1_8_buy = Small_home_1_8_load;

        int Small_home_1_9_load = PlayerPrefs.GetInt("Small_home_1_9_buy");
        Small_home_1_9_buy = Small_home_1_9_load;

        int Small_home_1_10_load = PlayerPrefs.GetInt("Small_home_1_10_buy");
        Small_home_1_10_buy = Small_home_1_10_load;

        int Small_home_1_11_load = PlayerPrefs.GetInt("Small_home_1_11_buy");
        Small_home_1_11_buy = Small_home_1_11_load;

        int Small_home_1_12_load = PlayerPrefs.GetInt("Small_home_1_12_buy");
        Small_home_1_12_buy = Small_home_1_12_load;
    
        int Small_home_2_1_load = PlayerPrefs.GetInt("Small_home_2_1_buy");
        Small_home_2_1_buy = Small_home_2_1_load;

        int Small_home_2_2_load = PlayerPrefs.GetInt("Small_home_2_2_buy");
        Small_home_2_2_buy = Small_home_2_2_load;

        int Small_home_2_3_load = PlayerPrefs.GetInt("Small_home_2_3_buy");
        Small_home_2_3_buy = Small_home_2_3_load;

        int Small_home_2_4_load = PlayerPrefs.GetInt("Small_home_2_4_buy");
        Small_home_2_4_buy = Small_home_2_4_load;

        int Small_home_2_5_load = PlayerPrefs.GetInt("Small_home_2_5_buy");
        Small_home_2_5_buy = Small_home_2_5_load;

        int Small_home_2_6_load = PlayerPrefs.GetInt("Small_home_2_6_buy");
        Small_home_2_6_buy = Small_home_2_6_load;

        int Small_home_2_7_load = PlayerPrefs.GetInt("Small_home_2_7_buy");
        Small_home_2_7_buy = Small_home_2_7_load;

        int Small_home_2_8_load = PlayerPrefs.GetInt("Small_home_2_8_buy");
        Small_home_2_8_buy = Small_home_2_8_load;

        int Small_home_2_9_load = PlayerPrefs.GetInt("Small_home_2_9_buy");
        Small_home_2_9_buy = Small_home_2_9_load;

        int Small_home_2_10_load = PlayerPrefs.GetInt("Small_home_2_10_buy");
        Small_home_2_10_buy = Small_home_2_10_load;

        int Small_home_2_11_load = PlayerPrefs.GetInt("Small_home_2_11_buy");
        Small_home_2_11_buy = Small_home_2_11_load;

        int Small_home_2_12_load = PlayerPrefs.GetInt("Small_home_2_12_buy");
        Small_home_2_12_buy = Small_home_2_12_load;

        int Small_home_3_1_load = PlayerPrefs.GetInt("Small_home_3_1_buy");
        Small_home_3_1_buy = Small_home_3_1_load;

        int Small_home_3_2_load = PlayerPrefs.GetInt("Small_home_3_2_buy");
        Small_home_3_2_buy = Small_home_3_2_load;

        int Small_home_3_3_load = PlayerPrefs.GetInt("Small_home_3_3_buy");
        Small_home_3_3_buy = Small_home_3_3_load;

        int Small_home_3_4_load = PlayerPrefs.GetInt("Small_home_3_4_buy");
        Small_home_3_4_buy = Small_home_3_4_load;

        int Small_home_3_5_load = PlayerPrefs.GetInt("Small_home_3_5_buy");
        Small_home_3_5_buy = Small_home_3_5_load;

        int Small_home_3_6_load = PlayerPrefs.GetInt("Small_home_3_6_buy");
        Small_home_3_6_buy = Small_home_3_6_load;

        int Small_home_3_7_load = PlayerPrefs.GetInt("Small_home_3_7_buy");
        Small_home_3_7_buy = Small_home_3_7_load;

        int Small_home_3_8_load = PlayerPrefs.GetInt("Small_home_3_8_buy");
        Small_home_3_8_buy = Small_home_3_8_load;

        int Small_home_3_9_load = PlayerPrefs.GetInt("Small_home_3_9_buy");
        Small_home_3_9_buy = Small_home_3_9_load;

        int Small_home_3_10_load = PlayerPrefs.GetInt("Small_home_3_10_buy");
        Small_home_3_10_buy = Small_home_3_10_load;

        int Small_home_3_11_load = PlayerPrefs.GetInt("Small_home_3_11_buy");
        Small_home_3_11_buy = Small_home_3_11_load;

        int Small_home_3_12_load = PlayerPrefs.GetInt("Small_home_3_12_buy");
        Small_home_3_12_buy = Small_home_3_12_load;
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


