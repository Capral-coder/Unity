using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class fire_station_buy : MonoBehaviour
{   
    private int Fire_station_buy;
    private int Fire_station_bild;

    private DateTime start_Fire_station = DateTime.Now;
    private float time = 60;
    private string nameprice;
    private int price;
    private string userid;
    private string loadusers;

    
    public string nameBuy;
    public int summ;
    public Text textSum;
    public TextMesh countdown_Fire_station;
    public GameObject Timer_Fire_station;

    public GameObject spawn_fire_truc;

    [SerializeField]
    GameObject Fire_station_prefab, Fire_station_bild_prefab;

    [SerializeField]
    GameObject Button_Fire_station_bild_1, Button_Fire_station_bild_2;

    [SerializeField]
    public GameObject ButStore,ButStore2,ButStore3,panelBox, sales;

    void Start()
    {
        //summ;
        int summ = PlayerPrefs.GetInt("summ");
        textSum.text = summ.ToString();

        int Fire_station_bild = PlayerPrefs.GetInt("Fire_station_bild");
        if (Fire_station_bild == 2)
        {
            Button_Fire_station_bild_1.SetActive(false);
            Button_Fire_station_bild_2.SetActive(true); 
            Fire_station_bild_prefab.SetActive(true);
            if (PlayerPrefs.HasKey("start_Fire_station"))
                start_Fire_station = DateTime.Parse(PlayerPrefs.GetString("start_Fire_station"));
            else
                PlayerPrefs.SetString("start_Fire_station", start_Fire_station.ToString());
            StartCoroutine(timer_Fire_station(start_Fire_station));

        }
        
        int Fire_station_buy = PlayerPrefs.GetInt("Fire_station_buy");
        if (Fire_station_buy == 2)
        {
            Fire_station_bild = 3;
            PlayerPrefs.SetInt("Fire_station_bild", Fire_station_bild);
            Fire_station_bild_prefab.SetActive(false);
            Fire_station_prefab.SetActive(true);
            Button_Fire_station_bild_1.SetActive(false);
            Button_Fire_station_bild_2.SetActive(true); 
        }
    }
    void Update()
    {

        int loadsum = PlayerPrefs.GetInt("summ");
        summ = loadsum;
        textSum.text = summ.ToString();

        int Fire_station_load = PlayerPrefs.GetInt("Fire_station_bild");
        Fire_station_bild = Fire_station_load;
        if(Fire_station_bild == 2)
        { 
            Debug.Log("Строиться");
        }

        int Fire_station_buy_load = PlayerPrefs.GetInt("Fire_station_buy");
        Fire_station_buy = Fire_station_buy_load;
        if(Fire_station_buy == 2)
        { 
            spawn_fire_truc.SetActive(true);
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
    
    public void BuyStoreFire_station()
    {
        nameBuy = "Fire_station";
        BuyStore();
    }
    public void BuyStore()
    {

        if (nameBuy == "Fire_station" && summ >= 500)
        {
            if (Fire_station_bild == 2 || Fire_station_bild == 3) 
            {
                sales.SetActive(true);
            }
            else
            {
                string loadusers = PlayerPrefs.GetString("userid");
                userid = loadusers;
                nameprice = "Fire_station";
                price = 500;
                StartCoroutine(BuyProduct());
                summ-=500;
                PlayerPrefs.SetInt("summ", summ);
                Fire_station_bild = 2;
                PlayerPrefs.SetInt("Fire_station_bild", Fire_station_bild);
                PlayerPrefs.Save();
                Button_Fire_station_bild_1.SetActive(false);
                Button_Fire_station_bild_2.SetActive(true);
                Fire_station_bild_prefab.SetActive(true);
                DateTime start_Fire_station = DateTime.Now;

                if (PlayerPrefs.HasKey("start_Fire_station"))
                    start_Fire_station = DateTime.Parse(PlayerPrefs.GetString("start_Fire_station"));
                else
                    PlayerPrefs.SetString("start_Fire_station", start_Fire_station.ToString());
                StartCoroutine(timer_Fire_station(start_Fire_station));
            }
        }
        else
        {
            panelBox.SetActive(true);
        }
            //int loadsum = PlayerPrefs.GetInt("summ");
            //summ = loadsum;
            //textSum.text = summ.ToString();
            int Fire_station_load = PlayerPrefs.GetInt("Fire_station_bild");
            Fire_station_bild = Fire_station_load;
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
    IEnumerator timer_Fire_station(DateTime start_Fire_station)
    {
        DateTime end = start_Fire_station.AddMinutes(30);
        while (DateTime.Now < end)
        {
            TimeSpan remaining = end - DateTime.Now;
            if (remaining.TotalSeconds > 1)
            {
                countdown_Fire_station.text = remaining.ToString("''m' : 's''");
                Debug.Log(remaining + " - countdown_Fire_station");   
            }
            yield return new WaitForSeconds(1f); 
        }
        Fire_station_bild_prefab.SetActive(false);
        Fire_station_buy = 2;
        PlayerPrefs.SetInt("Fire_station_buy", Fire_station_buy);
        PlayerPrefs.Save();
        Timer_Fire_station.SetActive(false);
        Fire_station_prefab.SetActive(true); 
    }


}