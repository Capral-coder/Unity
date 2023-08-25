using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class gas_station_buy : MonoBehaviour
{   
    private int Gas_station_buy;
    private int Gas_station_bild;
    private int Gas_station_buy_2;
    private int Gas_station_bild_2;

    private DateTime start_Gas_station = DateTime.Now;
    private float time = 60;
    private DateTime start_Gas_station_2 = DateTime.Now;
    private float time_2 = 60;
    private string nameprice;
    private int price;
    private string userid;
    private string loadusers;
    
    public string nameBuy;
    public int summ;
    public Text textSum;
    public TextMesh countdown_Gas_station;
    public GameObject Timer_Gas_station;

    public TextMesh countdown_Gas_station_2;
    public GameObject Timer_Gas_station_2;

    [SerializeField]
    GameObject Gas_station_prefab, Gas_station_bild_prefab, Gas_station_prefab_2, Gas_station_bild_prefab_2 ;

    [SerializeField]
    GameObject Button_Gas_station_bild_1, Button_Gas_station_bild_2, Button_Gas_station_bild_3;

    [SerializeField]
    public GameObject panelBox, sales;

    void Start()
    {
        //summ;
        int summ = PlayerPrefs.GetInt("summ");
        textSum.text = summ.ToString();
        panelBox.SetActive(false);
        sales.SetActive(false);

        int Gas_station_bild = PlayerPrefs.GetInt("Gas_station_bild");
        if (Gas_station_bild == 2)
        {
            Button_Gas_station_bild_1.SetActive(false);
            Button_Gas_station_bild_2.SetActive(true); 
            Gas_station_bild_prefab.SetActive(true);
            if (PlayerPrefs.HasKey("start_Gas_station"))
                start_Gas_station = DateTime.Parse(PlayerPrefs.GetString("start_Gas_station"));
            else
                PlayerPrefs.SetString("start_Gas_station", start_Gas_station.ToString());
            StartCoroutine(timer_Gas_station(start_Gas_station));

        }
        
        int Gas_station_buy = PlayerPrefs.GetInt("Gas_station_buy");
        if (Gas_station_buy == 2)
        {
            Gas_station_bild = 3;
            PlayerPrefs.SetInt("Gas_station_bild", Gas_station_bild);
            Gas_station_bild_prefab.SetActive(false);
            Gas_station_prefab.SetActive(true);
            Button_Gas_station_bild_1.SetActive(false);
            Button_Gas_station_bild_2.SetActive(true); 
        }

        int Gas_station_bild_2 = PlayerPrefs.GetInt("Gas_station_bild_2");
        if (Gas_station_bild_2 == 2)
        {
            Button_Gas_station_bild_2.SetActive(false);
            Button_Gas_station_bild_3.SetActive(true); 
            Gas_station_bild_prefab_2.SetActive(true);
            if (PlayerPrefs.HasKey("start_Gas_station_2"))
                start_Gas_station_2 = DateTime.Parse(PlayerPrefs.GetString("start_Gas_station_2"));
            else
                PlayerPrefs.SetString("start_Gas_station_2", start_Gas_station_2.ToString());
            StartCoroutine(timer_Gas_station_2(start_Gas_station_2));

        }
        
        int Gas_station_buy_2 = PlayerPrefs.GetInt("Gas_station_buy_2");
        if (Gas_station_buy_2 == 2)
        {
            Gas_station_bild_2 = 3;
            PlayerPrefs.SetInt("Gas_station_bild_2", Gas_station_bild_2);
            Gas_station_bild_prefab_2.SetActive(false);
            Gas_station_prefab_2.SetActive(true);
            Button_Gas_station_bild_2.SetActive(false);
            Button_Gas_station_bild_3.SetActive(true); 
        }
    }
    void Update()
    {

        int loadsum = PlayerPrefs.GetInt("summ");
        summ = loadsum;
        textSum.text = summ.ToString();


        int Gas_station_load = PlayerPrefs.GetInt("Gas_station_bild");
        Gas_station_bild = Gas_station_load;
        if(Gas_station_bild == 2)
        { 
            Debug.Log("Строиться");
        }

        int Gas_station_buy_load = PlayerPrefs.GetInt("Gas_station_buy");
        Gas_station_buy = Gas_station_buy_load;
        if(Gas_station_buy == 2)
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
        int Gas_station_buy_load_2 = PlayerPrefs.GetInt("Gas_station_buy_2");
        Gas_station_buy_2 = Gas_station_buy_load_2;
        if(Gas_station_buy_2 == 2)
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
  
    public void BuyStoreGas_station()
    {
        nameBuy = "Gas_station";
        BuyStore();
    }

    public void BuyStoreGas_station_2()
    {
        nameBuy = "Gas_station_2";
        BuyStore();
    }
    public void BuyStore()
    {

        if (nameBuy == "Gas_station" && summ >= 300)
        {
            if (Gas_station_bild == 2 || Gas_station_bild == 3) 
            {
                sales.SetActive(true);
            }
            else
            {
                string loadusers = PlayerPrefs.GetString("userid");
                userid = loadusers;
                nameprice = "Gas_station";
                price = 300;
                StartCoroutine(BuyProduct());
                summ-=300;
                PlayerPrefs.SetInt("summ", summ);
                Gas_station_bild = 2;
                PlayerPrefs.SetInt("Gas_station_bild", Gas_station_bild);
                PlayerPrefs.Save();
                Button_Gas_station_bild_1.SetActive(false);
                Button_Gas_station_bild_2.SetActive(true);
                Gas_station_bild_prefab.SetActive(true);
                DateTime start_Gas_station = DateTime.Now;

                if (PlayerPrefs.HasKey("start_Gas_station"))
                    start_Gas_station = DateTime.Parse(PlayerPrefs.GetString("start_Gas_station"));
                else
                    PlayerPrefs.SetString("start_Gas_station", start_Gas_station.ToString());
                StartCoroutine(timer_Gas_station(start_Gas_station));
            }
        }

        else if (nameBuy == "Gas_station_2" && summ >= 300)
        {
            if (Gas_station_bild_2 == 2 || Gas_station_bild == 3) 
            {
                sales.SetActive(true);
            }
            else
            {
                string loadusers = PlayerPrefs.GetString("userid");
                userid = loadusers;
                nameprice = "Gas_station_2";
                price = 300;
                StartCoroutine(BuyProduct());
                summ-=300;
                PlayerPrefs.SetInt("summ", summ);
                Gas_station_bild_2 = 2;
                PlayerPrefs.SetInt("Gas_station_bild_2", Gas_station_bild_2);
                PlayerPrefs.Save();
                Button_Gas_station_bild_2.SetActive(false);
                Button_Gas_station_bild_3.SetActive(true);
                Gas_station_bild_prefab_2.SetActive(true);
                DateTime start_Gas_station_2 = DateTime.Now;

                if (PlayerPrefs.HasKey("start_Gas_station_2"))
                    start_Gas_station_2 = DateTime.Parse(PlayerPrefs.GetString("start_Gas_station_2"));
                else
                    PlayerPrefs.SetString("start_Gas_station_2", start_Gas_station_2.ToString());
                StartCoroutine(timer_Gas_station_2(start_Gas_station_2));
            }
        }

        else
        {
            panelBox.SetActive(true);
        }
            //int loadsum = PlayerPrefs.GetInt("summ");
            //summ = loadsum;
            //textSum.text = summ.ToString();
            int Gas_station_load = PlayerPrefs.GetInt("Gas_station_bild");
            Gas_station_bild = Gas_station_load;

            int Gas_station_load_2 = PlayerPrefs.GetInt("Gas_station_bild_2");
            Gas_station_bild_2 = Gas_station_load_2;
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
    IEnumerator timer_Gas_station(DateTime start_Gas_station)
    {
        DateTime end = start_Gas_station.AddMinutes(20);
        while (DateTime.Now < end)
        {
            TimeSpan remaining = end - DateTime.Now;
            if (remaining.TotalSeconds > 1)
            {
                countdown_Gas_station.text = remaining.ToString("''m' : 's''");
                Debug.Log(remaining + " - countdown_Gas_station");   
            }
            yield return new WaitForSeconds(1f); 
        }
        Gas_station_bild_prefab.SetActive(false);
        Gas_station_buy = 2;
        PlayerPrefs.SetInt("Gas_station_buy", Gas_station_buy);
        PlayerPrefs.Save();
        Timer_Gas_station.SetActive(false);
        Gas_station_prefab.SetActive(true); 
    }

    IEnumerator timer_Gas_station_2(DateTime start_Gas_station_2)
    {
        DateTime end = start_Gas_station_2.AddMinutes(20);
        while (DateTime.Now < end)
        {
            TimeSpan remaining = end - DateTime.Now;
            if (remaining.TotalSeconds > 1)
            {
                countdown_Gas_station_2.text = remaining.ToString("''m' : 's''");
                Debug.Log(remaining + " - countdown_Gas_station_2");   
            }
            yield return new WaitForSeconds(1f); 
        }
        Gas_station_bild_prefab_2.SetActive(false);
        Gas_station_buy_2 = 2;
        PlayerPrefs.SetInt("Gas_station_buy_2", Gas_station_buy_2);
        PlayerPrefs.Save();
        Timer_Gas_station_2.SetActive(false);
        Gas_station_prefab_2.SetActive(true); 
    }


}