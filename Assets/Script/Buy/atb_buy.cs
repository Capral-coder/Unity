using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class atb_buy : MonoBehaviour
{   
    private int ATB_buy;
    private int ATB_bild;
    private int ATB_buy_2;
    private int ATB_bild_2;

    private DateTime start_ATB = DateTime.Now;
    private float time = 60;
    private DateTime start_ATB_2 = DateTime.Now;
    private float time_2 = 60;
    private string nameprice;
    private int price;
    private string userid;
    private string loadusers;
    
    public string nameBuy;
    public int summ;
    public Text textSum;
    public TextMesh countdown_ATB;
    public GameObject Timer_ATB;

    public TextMesh countdown_ATB_2;
    public GameObject Timer_ATB_2;

    [SerializeField]
    GameObject ATB_prefab, ATB_bild_prefab, ATB_prefab_2, ATB_bild_prefab_2 ;

    [SerializeField]
    GameObject Button_ATB_bild_1, Button_ATB_bild_2, Button_ATB_bild_3;

    [SerializeField]
    public GameObject panelBox, sales;

    void Start()
    {
        //summ;
        int summ = PlayerPrefs.GetInt("summ");
        textSum.text = summ.ToString();
        panelBox.SetActive(false);
        sales.SetActive(false);

        int ATB_bild = PlayerPrefs.GetInt("ATB_bild");
        if (ATB_bild == 2)
        {
            Button_ATB_bild_1.SetActive(false);
            Button_ATB_bild_2.SetActive(true); 
            ATB_bild_prefab.SetActive(true);
            if (PlayerPrefs.HasKey("start_ATB"))
                start_ATB = DateTime.Parse(PlayerPrefs.GetString("start_ATB"));
            else
                PlayerPrefs.SetString("start_ATB", start_ATB.ToString());
            StartCoroutine(timer_ATB(start_ATB));

        }
        
        int ATB_buy = PlayerPrefs.GetInt("ATB_buy");
        if (ATB_buy == 2)
        {
            ATB_bild = 3;
            PlayerPrefs.SetInt("ATB_bild", ATB_bild);
            ATB_bild_prefab.SetActive(false);
            ATB_prefab.SetActive(true);
            Button_ATB_bild_1.SetActive(false);
            Button_ATB_bild_2.SetActive(true);
        }

        int ATB_bild_2 = PlayerPrefs.GetInt("ATB_bild_2");
        if (ATB_bild_2 == 2)
        {
            Button_ATB_bild_2.SetActive(false);
            Button_ATB_bild_3.SetActive(true); 
            ATB_bild_prefab_2.SetActive(true);
            if (PlayerPrefs.HasKey("start_ATB_2"))
                start_ATB_2 = DateTime.Parse(PlayerPrefs.GetString("start_ATB_2"));
            else
                PlayerPrefs.SetString("start_ATB_2", start_ATB_2.ToString());
            StartCoroutine(timer_ATB_2(start_ATB_2));

        }
        
        int ATB_buy_2 = PlayerPrefs.GetInt("ATB_buy_2");
        if (ATB_buy_2 == 2)
        {
            ATB_bild_2 = 3;
            PlayerPrefs.SetInt("ATB_bild_2", ATB_bild_2);
            ATB_bild_prefab_2.SetActive(false);
            ATB_prefab_2.SetActive(true);
            Button_ATB_bild_2.SetActive(false);
            Button_ATB_bild_3.SetActive(true); 
        }
    }
    void Update()
    {

        int loadsum = PlayerPrefs.GetInt("summ");
        summ = loadsum;
        textSum.text = summ.ToString();

        int ATB_buy_load = PlayerPrefs.GetInt("ATB_buy");
        ATB_buy = ATB_buy_load;
        if(ATB_buy == 2)
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
        int ATB_buy_load_2 = PlayerPrefs.GetInt("ATB_buy_2");
        ATB_buy_2 = ATB_buy_load_2;
        if(ATB_buy_2 == 2)
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
  
    public void BuyStoreATB()
    {
        nameBuy = "ATB";
        BuyStore();
    }

    public void BuyStoreATB_2()
    {
        nameBuy = "ATB_2";
        BuyStore();
    }
    public void BuyStore()
    {

        if (nameBuy == "ATB" && summ >= 300)
        {
            if (ATB_bild == 2 || ATB_bild == 3) 
            {
                sales.SetActive(true);
            }
            else
            {
                string loadusers = PlayerPrefs.GetString("userid");
                userid = loadusers;
                nameprice = "ATB";
                price = 300;
                StartCoroutine(BuyProduct());
                summ-=300;
                PlayerPrefs.SetInt("summ", summ);
                ATB_bild = 2;
                PlayerPrefs.SetInt("ATB_bild", ATB_bild);
                PlayerPrefs.Save();
                Button_ATB_bild_1.SetActive(false);
                Button_ATB_bild_2.SetActive(true);
                ATB_bild_prefab.SetActive(true);
                DateTime start_ATB = DateTime.Now;

                if (PlayerPrefs.HasKey("start_ATB"))
                    start_ATB = DateTime.Parse(PlayerPrefs.GetString("start_ATB"));
                else
                    PlayerPrefs.SetString("start_ATB", start_ATB.ToString());
                StartCoroutine(timer_ATB(start_ATB));
            }
        }

        else if (nameBuy == "ATB_2" && summ >= 300)
        {
            if (ATB_bild_2 == 2 || ATB_bild == 3) 
            {
                sales.SetActive(true);
            }
            else
            {
                string loadusers = PlayerPrefs.GetString("userid");
                userid = loadusers;
                nameprice = "ATB_2";
                price = 300;
                StartCoroutine(BuyProduct());
                summ-=300;
                PlayerPrefs.SetInt("summ", summ);
                ATB_bild_2 = 2;
                PlayerPrefs.SetInt("ATB_bild_2", ATB_bild_2);
                PlayerPrefs.Save();
                Button_ATB_bild_2.SetActive(false);
                Button_ATB_bild_3.SetActive(true);
                ATB_bild_prefab_2.SetActive(true);
                DateTime start_ATB_2 = DateTime.Now;

                if (PlayerPrefs.HasKey("start_ATB_2"))
                    start_ATB_2 = DateTime.Parse(PlayerPrefs.GetString("start_ATB_2"));
                else
                    PlayerPrefs.SetString("start_ATB_2", start_ATB_2.ToString());
                StartCoroutine(timer_ATB_2(start_ATB_2));
            }
        }

        else
        {
            panelBox.SetActive(true);
        }
            //int loadsum = PlayerPrefs.GetInt("summ");
            //summ = loadsum;
            //textSum.text = summ.ToString();
            int ATB_load = PlayerPrefs.GetInt("ATB_bild");
            ATB_bild = ATB_load;

            int ATB_load_2 = PlayerPrefs.GetInt("ATB_bild_2");
            ATB_bild_2 = ATB_load_2;
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
    IEnumerator timer_ATB(DateTime start_ATB)
    {
        DateTime end = start_ATB.AddMinutes(20);
        while (DateTime.Now < end)
        {
            TimeSpan remaining = end - DateTime.Now;
            if (remaining.TotalSeconds > 1)
            {
                countdown_ATB.text = remaining.ToString("''m' : 's''");
                Debug.Log(remaining + " - countdown_ATB");   
            }
            yield return new WaitForSeconds(1f); 
        }
        ATB_bild_prefab.SetActive(false);
        ATB_buy = 2;
        PlayerPrefs.SetInt("ATB_buy", ATB_buy);
        PlayerPrefs.Save();
        Timer_ATB.SetActive(false);
        ATB_prefab.SetActive(true); 
    }

    IEnumerator timer_ATB_2(DateTime start_ATB_2)
    {
        DateTime end = start_ATB_2.AddMinutes(20);
        while (DateTime.Now < end)
        {
            TimeSpan remaining = end - DateTime.Now;
            if (remaining.TotalSeconds > 1)
            {
                countdown_ATB_2.text = remaining.ToString("''m' : 's''");
                Debug.Log(remaining + " - countdown_ATB_2");   
            }
            yield return new WaitForSeconds(1f); 
        }
        ATB_bild_prefab_2.SetActive(false);
        ATB_buy_2 = 2;
        PlayerPrefs.SetInt("ATB_buy_2", ATB_buy_2);
        PlayerPrefs.Save();
        Timer_ATB_2.SetActive(false);
        ATB_prefab_2.SetActive(true); 
    }


}