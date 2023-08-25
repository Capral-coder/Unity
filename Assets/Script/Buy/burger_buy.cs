using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class burger_buy : MonoBehaviour
{   
    private int Burger_buy;
    private int Burger_bild;
    private int Burger_buy_2;
    private int Burger_bild_2;

    private DateTime start_Burger = DateTime.Now;
    private float time = 60;
    private DateTime start_Burger_2 = DateTime.Now;
    private float time_2 = 60;
    private string nameprice;
    private int price;
    private string userid;
    private string loadusers;
    
    public string nameBuy;
    public int summ;
    public Text textSum;
    public TextMesh countdown_Burger;
    public GameObject Timer_Burger;

    public TextMesh countdown_Burger_2;
    public GameObject Timer_Burger_2;

    [SerializeField]
    GameObject Burger_prefab, Burger_bild_prefab, Burger_prefab_2, Burger_bild_prefab_2 ;

    [SerializeField]
    GameObject Button_Burger_bild_1, Button_Burger_bild_2, Button_Burger_bild_3;

    [SerializeField]
    public GameObject panelBox, sales;

    void Start()
    {
        //summ;
        int summ = PlayerPrefs.GetInt("summ");
        textSum.text = summ.ToString();
        panelBox.SetActive(false);
        sales.SetActive(false);

        int Burger_bild = PlayerPrefs.GetInt("Burger_bild");
        if (Burger_bild == 2)
        {
            Button_Burger_bild_1.SetActive(false);
            Button_Burger_bild_2.SetActive(true); 
            Burger_bild_prefab.SetActive(true);
            if (PlayerPrefs.HasKey("start_Burger"))
                start_Burger = DateTime.Parse(PlayerPrefs.GetString("start_Burger"));
            else
                PlayerPrefs.SetString("start_Burger", start_Burger.ToString());
            StartCoroutine(timer_Burger(start_Burger));

        }
        
        int Burger_buy = PlayerPrefs.GetInt("Burger_buy");
        if (Burger_buy == 2)
        {
            Burger_bild = 3;
            PlayerPrefs.SetInt("Burger_bild", Burger_bild);
            Burger_bild_prefab.SetActive(false);
            Burger_prefab.SetActive(true);
            Button_Burger_bild_1.SetActive(false);
            Button_Burger_bild_2.SetActive(true); 
        }

        int Burger_bild_2 = PlayerPrefs.GetInt("Burger_bild_2");
        if (Burger_bild_2 == 2)
        {
            Button_Burger_bild_2.SetActive(false);
            Button_Burger_bild_3.SetActive(true); 
            Burger_bild_prefab_2.SetActive(true);
            if (PlayerPrefs.HasKey("start_Burger_2"))
                start_Burger_2 = DateTime.Parse(PlayerPrefs.GetString("start_Burger_2"));
            else
                PlayerPrefs.SetString("start_Burger_2", start_Burger_2.ToString());
            StartCoroutine(timer_Burger_2(start_Burger_2));

        }
        
        int Burger_buy_2 = PlayerPrefs.GetInt("Burger_buy_2");
        if (Burger_buy_2 == 2)
        {
            Burger_bild_2 = 3;
            PlayerPrefs.SetInt("Burger_bild_2", Burger_bild_2);
            Burger_bild_prefab_2.SetActive(false);
            Burger_prefab_2.SetActive(true);
            Button_Burger_bild_2.SetActive(false);
            Button_Burger_bild_3.SetActive(true); 
        }
    }
    void Update()
    {

        int loadsum = PlayerPrefs.GetInt("summ");
        summ = loadsum;
        textSum.text = summ.ToString();


        int Burger_load = PlayerPrefs.GetInt("Burger_bild");
        Burger_bild = Burger_load;
        if(Burger_bild == 2)
        { 
            Debug.Log("Строиться");
        }

        int Burger_buy_load = PlayerPrefs.GetInt("Burger_buy");
        Burger_buy = Burger_buy_load;
        if(Burger_buy == 2)
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
        int Burger_buy_load_2 = PlayerPrefs.GetInt("Burger_buy_2");
        Burger_buy_2 = Burger_buy_load_2;
        if(Burger_buy_2 == 2)
        { 
            time_2 -= Time.deltaTime;
            if(time_2 <= 0)
            {
                summ+=5;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time_2 = 60f;
            }
        }
    }
  
    public void BuyStoreBurger()
    {
        nameBuy = "Burger";
        BuyStore();
    }

    public void BuyStoreBurger_2()
    {
        nameBuy = "Burger_2";
        BuyStore();
    }
    public void BuyStore()
    {

        if (nameBuy == "Burger" && summ >= 300)
        {
            if (Burger_bild == 2 || Burger_bild == 3) 
            {
                sales.SetActive(true);
            }
            else
            {
                string loadusers = PlayerPrefs.GetString("userid");
                userid = loadusers;
                nameprice = "Burger";
                price = 300;
                StartCoroutine(BuyProduct());
                summ-=300;
                PlayerPrefs.SetInt("summ", summ);
                Burger_bild = 2;
                PlayerPrefs.SetInt("Burger_bild", Burger_bild);
                PlayerPrefs.Save();
                Button_Burger_bild_1.SetActive(false);
                Button_Burger_bild_2.SetActive(true);
                Burger_bild_prefab.SetActive(true);
                DateTime start_Burger = DateTime.Now;

                if (PlayerPrefs.HasKey("start_Burger"))
                    start_Burger = DateTime.Parse(PlayerPrefs.GetString("start_Burger"));
                else
                    PlayerPrefs.SetString("start_Burger", start_Burger.ToString());
                StartCoroutine(timer_Burger(start_Burger));
            }
        }

        else if (nameBuy == "Burger_2" && summ >= 300)
        {
            if (Burger_bild_2 == 2 || Burger_bild == 3) 
            {
                sales.SetActive(true);
            }
            else
            {
                string loadusers = PlayerPrefs.GetString("userid");
                userid = loadusers;
                nameprice = "Burger_2";
                price = 300;
                StartCoroutine(BuyProduct());
                summ-=300;
                PlayerPrefs.SetInt("summ", summ);
                Burger_bild_2 = 2;
                PlayerPrefs.SetInt("Burger_bild_2", Burger_bild_2);
                PlayerPrefs.Save();
                Button_Burger_bild_2.SetActive(false);
                Button_Burger_bild_3.SetActive(true);
                Burger_bild_prefab_2.SetActive(true);
                DateTime start_Burger_2 = DateTime.Now;

                if (PlayerPrefs.HasKey("start_Burger_2"))
                    start_Burger_2 = DateTime.Parse(PlayerPrefs.GetString("start_Burger_2"));
                else
                    PlayerPrefs.SetString("start_Burger_2", start_Burger_2.ToString());
                StartCoroutine(timer_Burger_2(start_Burger_2));
            }
        }

        else
        {
            panelBox.SetActive(true);
        }
            //int loadsum = PlayerPrefs.GetInt("summ");
            //summ = loadsum;
            //textSum.text = summ.ToString();
            int Burger_load = PlayerPrefs.GetInt("Burger_bild");
            Burger_bild = Burger_load;

            int Burger_load_2 = PlayerPrefs.GetInt("Burger_bild_2");
            Burger_bild_2 = Burger_load_2;
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
    IEnumerator timer_Burger(DateTime start_Burger)
    {
        DateTime end = start_Burger.AddMinutes(20);
        while (DateTime.Now < end)
        {
            TimeSpan remaining = end - DateTime.Now;
            if (remaining.TotalSeconds > 1)
            {
                countdown_Burger.text = remaining.ToString("''m' : 's''");
                Debug.Log(remaining + " - countdown_Burger");   
            }
            yield return new WaitForSeconds(1f); 
        }
        Burger_bild_prefab.SetActive(false);
        Burger_buy = 2;
        PlayerPrefs.SetInt("Burger_buy", Burger_buy);
        PlayerPrefs.Save();
        Timer_Burger.SetActive(false);
        Burger_prefab.SetActive(true); 
    }

    IEnumerator timer_Burger_2(DateTime start_Burger_2)
    {
        DateTime end = start_Burger_2.AddMinutes(20);
        while (DateTime.Now < end)
        {
            TimeSpan remaining = end - DateTime.Now;
            if (remaining.TotalSeconds > 1)
            {
                countdown_Burger_2.text = remaining.ToString("''m' : 's''");
                Debug.Log(remaining + " - countdown_Burger_2");   
            }
            yield return new WaitForSeconds(1f); 
        }
        Burger_bild_prefab_2.SetActive(false);
        Burger_buy_2 = 2;
        PlayerPrefs.SetInt("Burger_buy_2", Burger_buy_2);
        PlayerPrefs.Save();
        Timer_Burger_2.SetActive(false);
        Burger_prefab_2.SetActive(true); 
    }


}