using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class gym_buy : MonoBehaviour
{   
    private int GYM_buy;
    private int GYM_bild;
    private int GYM_buy_2;
    private int GYM_bild_2;

    private DateTime start_GYM = DateTime.Now;
    private float time = 60;
    private DateTime start_GYM_2 = DateTime.Now;
    private float time_2 = 60;
    private string nameprice;
    private int price;
    private string userid;
    private string loadusers;
    
    public string nameBuy;
    public int summ;
    public Text textSum;
    public TextMesh countdown_GYM;
    public GameObject Timer_GYM;

    public TextMesh countdown_GYM_2;
    public GameObject Timer_GYM_2;

    [SerializeField]
    GameObject GYM_prefab, GYM_bild_prefab, GYM_prefab_2, GYM_bild_prefab_2 ;

    [SerializeField]
    GameObject Button_GYM_bild_1, Button_GYM_bild_2, Button_GYM_bild_3;

    [SerializeField]
    public GameObject panelBox, sales;

    void Start()
    {
        //summ;
        int summ = PlayerPrefs.GetInt("summ");
        textSum.text = summ.ToString();
        panelBox.SetActive(false);
        sales.SetActive(false);

        int GYM_bild = PlayerPrefs.GetInt("GYM_bild");
        if (GYM_bild == 2)
        {
            Button_GYM_bild_1.SetActive(false);
            Button_GYM_bild_2.SetActive(true); 
            GYM_bild_prefab.SetActive(true);
            if (PlayerPrefs.HasKey("start_GYM"))
                start_GYM = DateTime.Parse(PlayerPrefs.GetString("start_GYM"));
            else
                PlayerPrefs.SetString("start_GYM", start_GYM.ToString());
            StartCoroutine(timer_GYM(start_GYM));

        }
        
        int GYM_buy = PlayerPrefs.GetInt("GYM_buy");
        if (GYM_buy == 2)
        {
            GYM_bild = 3;
            PlayerPrefs.SetInt("GYM_bild", GYM_bild);
            GYM_bild_prefab.SetActive(false);
            GYM_prefab.SetActive(true);
            Button_GYM_bild_1.SetActive(false);
            Button_GYM_bild_2.SetActive(true); 
        }

        int GYM_bild_2 = PlayerPrefs.GetInt("GYM_bild_2");
        if (GYM_bild_2 == 2)
        {
            Button_GYM_bild_2.SetActive(false);
            Button_GYM_bild_3.SetActive(true); 
            GYM_bild_prefab_2.SetActive(true);
            if (PlayerPrefs.HasKey("start_GYM_2"))
                start_GYM_2 = DateTime.Parse(PlayerPrefs.GetString("start_GYM_2"));
            else
                PlayerPrefs.SetString("start_GYM_2", start_GYM_2.ToString());
            StartCoroutine(timer_GYM_2(start_GYM_2));

        }
        
        int GYM_buy_2 = PlayerPrefs.GetInt("GYM_buy_2");
        if (GYM_buy_2 == 2)
        {
            GYM_bild_2 = 3;
            PlayerPrefs.SetInt("GYM_bild_2", GYM_bild_2);
            GYM_bild_prefab_2.SetActive(false);
            GYM_prefab_2.SetActive(true);
            Button_GYM_bild_2.SetActive(false);
            Button_GYM_bild_3.SetActive(true); 
        }
    }
    void Update()
    {

        int loadsum = PlayerPrefs.GetInt("summ");
        summ = loadsum;
        textSum.text = summ.ToString();


        int GYM_load = PlayerPrefs.GetInt("GYM_bild");
        GYM_bild = GYM_load;
        if(GYM_bild == 2)
        { 
            Debug.Log("Строиться");
        }

        int GYM_buy_load = PlayerPrefs.GetInt("GYM_buy");
        GYM_buy = GYM_buy_load;
        if(GYM_buy == 2)
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
        int GYM_buy_load_2 = PlayerPrefs.GetInt("GYM_buy_2");
        GYM_buy_2 = GYM_buy_load_2;
        if(GYM_buy_2 == 2)
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
  
    public void BuyStoreGYM()
    {
        nameBuy = "GYM";
        BuyStore();
    }

    public void BuyStoreGYM_2()
    {
        nameBuy = "GYM_2";
        BuyStore();
    }
    public void BuyStore()
    {

        if (nameBuy == "GYM" && summ >= 300)
        {
            if (GYM_bild == 2 || GYM_bild == 3) 
            {
                sales.SetActive(true);
            }
            else
            {
                string loadusers = PlayerPrefs.GetString("userid");
                userid = loadusers;
                nameprice = "GYM";
                price = 300;
                StartCoroutine(BuyProduct());
                summ-=300;
                PlayerPrefs.SetInt("summ", summ);
                GYM_bild = 2;
                PlayerPrefs.SetInt("GYM_bild", GYM_bild);
                PlayerPrefs.Save();
                Button_GYM_bild_1.SetActive(false);
                Button_GYM_bild_2.SetActive(true);
                GYM_bild_prefab.SetActive(true);
                DateTime start_GYM = DateTime.Now;

                if (PlayerPrefs.HasKey("start_GYM"))
                    start_GYM = DateTime.Parse(PlayerPrefs.GetString("start_GYM"));
                else
                    PlayerPrefs.SetString("start_GYM", start_GYM.ToString());
                StartCoroutine(timer_GYM(start_GYM));
            }
        }

        else if (nameBuy == "GYM_2" && summ >= 300)
        {
            if (GYM_bild_2 == 2 || GYM_bild == 3) 
            {
                sales.SetActive(true);
            }
            else
            {
                string loadusers = PlayerPrefs.GetString("userid");
                userid = loadusers;
                nameprice = "GYM_2";
                price = 300;
                StartCoroutine(BuyProduct());
                summ-=300;
                PlayerPrefs.SetInt("summ", summ);
                GYM_bild_2 = 2;
                PlayerPrefs.SetInt("GYM_bild_2", GYM_bild_2);
                PlayerPrefs.Save();
                Button_GYM_bild_2.SetActive(false);
                Button_GYM_bild_3.SetActive(true);
                GYM_bild_prefab_2.SetActive(true);
                DateTime start_GYM_2 = DateTime.Now;

                if (PlayerPrefs.HasKey("start_GYM_2"))
                    start_GYM_2 = DateTime.Parse(PlayerPrefs.GetString("start_GYM_2"));
                else
                    PlayerPrefs.SetString("start_GYM_2", start_GYM_2.ToString());
                StartCoroutine(timer_GYM_2(start_GYM_2));
            }
        }

        else
        {
            panelBox.SetActive(true);
        }
            //int loadsum = PlayerPrefs.GetInt("summ");
            //summ = loadsum;
            //textSum.text = summ.ToString();
            int GYM_load = PlayerPrefs.GetInt("GYM_bild");
            GYM_bild = GYM_load;

            int GYM_load_2 = PlayerPrefs.GetInt("GYM_bild_2");
            GYM_bild_2 = GYM_load_2;
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
    IEnumerator timer_GYM(DateTime start_GYM)
    {
        DateTime end = start_GYM.AddMinutes(20);
        while (DateTime.Now < end)
        {
            TimeSpan remaining = end - DateTime.Now;
            if (remaining.TotalSeconds > 1)
            {
                countdown_GYM.text = remaining.ToString("''m' : 's''");
                Debug.Log(remaining + " - countdown_GYM");   
            }
            yield return new WaitForSeconds(1f); 
        }
        GYM_bild_prefab.SetActive(false);
        GYM_buy = 2;
        PlayerPrefs.SetInt("GYM_buy", GYM_buy);
        PlayerPrefs.Save();
        Timer_GYM.SetActive(false);
        GYM_prefab.SetActive(true); 
    }

    IEnumerator timer_GYM_2(DateTime start_GYM_2)
    {
        DateTime end = start_GYM_2.AddMinutes(20);
        while (DateTime.Now < end)
        {
            TimeSpan remaining = end - DateTime.Now;
            if (remaining.TotalSeconds > 1)
            {
                countdown_GYM_2.text = remaining.ToString("''m' : 's''");
                Debug.Log(remaining + " - countdown_GYM_2");   
            }
            yield return new WaitForSeconds(1f); 
        }
        GYM_bild_prefab_2.SetActive(false);
        GYM_buy_2 = 2;
        PlayerPrefs.SetInt("GYM_buy_2", GYM_buy_2);
        PlayerPrefs.Save();
        Timer_GYM_2.SetActive(false);
        GYM_prefab_2.SetActive(true); 
    }


}