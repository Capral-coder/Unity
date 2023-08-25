using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class hotel_buy : MonoBehaviour
{   
    private int Hotel_buy;
    private int Hotel_bild;

    private DateTime start_Hotel = DateTime.Now;
    private float time = 60;
    private string nameprice;
    private int price;
    private string userid;
    private string loadusers;
    
    public string nameBuy;
    public int summ;
    public Text textSum;
    public TextMesh countdown_Hotel;
    public GameObject Timer_Hotel;

    [SerializeField]
    GameObject Hotel_prefab, Hotel_bild_prefab;

    [SerializeField]
    GameObject Button_Hotel_bild_1, Button_Hotel_bild_2;

    [SerializeField]
    public GameObject panelBox, sales;

    void Start()
    {
        //summ;
        int summ = PlayerPrefs.GetInt("summ");
        textSum.text = summ.ToString();
        panelBox.SetActive(false);
        sales.SetActive(false);

        int Hotel_bild = PlayerPrefs.GetInt("Hotel_bild");
        if (Hotel_bild == 2)
        {
            Button_Hotel_bild_1.SetActive(false);
            Button_Hotel_bild_2.SetActive(true); 
            Hotel_bild_prefab.SetActive(true);

            if (PlayerPrefs.HasKey("start_Hotel"))
                start_Hotel = DateTime.Parse(PlayerPrefs.GetString("start_Hotel"));
            else
                PlayerPrefs.SetString("start_Hotel", start_Hotel.ToString());
            StartCoroutine(timer_Hotel(start_Hotel));

        }
        
        int Hotel_buy = PlayerPrefs.GetInt("Hotel_buy");
        if (Hotel_buy == 2)
        {
            Hotel_bild = 3;
            PlayerPrefs.SetInt("Hotel_bild", Hotel_bild);
            Hotel_bild_prefab.SetActive(false);
            Hotel_prefab.SetActive(true);
            Button_Hotel_bild_1.SetActive(false);
            Button_Hotel_bild_2.SetActive(true);
        }
    }
    void Update()
    {

        int loadsum = PlayerPrefs.GetInt("summ");
        summ = loadsum;
        textSum.text = summ.ToString();

        int Hotel_load = PlayerPrefs.GetInt("Hotel_bild");
        Hotel_bild = Hotel_load;
        if(Hotel_bild == 2)
        { 
            Debug.Log("Строиться");
        }

        int Hotel_buy_load = PlayerPrefs.GetInt("Hotel_buy");
        Hotel_buy = Hotel_buy_load;
        if(Hotel_buy == 2)
        { 
            time -= Time.deltaTime;
            if(time <= 0)
            {
                summ+=2;
                PlayerPrefs.SetInt("summ", summ);
                PlayerPrefs.Save();
                Debug.Log("Прошла 1 мин!");
                time = 60f;
            }
        }
    }

    
    public void BuyStoreHotel()
    {
        nameBuy = "Hotel";
        BuyStore();
    }
    public void BuyStore()
    {

        if (nameBuy == "Hotel" && summ >= 500)
        {
            if (Hotel_bild == 2 || Hotel_bild == 3) 
            {
                sales.SetActive(true);
            }
            else
            {
                string loadusers = PlayerPrefs.GetString("userid");
                userid = loadusers;
                nameprice = "Hotel";
                price = 500;
                StartCoroutine(BuyProduct());
                summ-=500;
                PlayerPrefs.SetInt("summ", summ);
                Hotel_bild = 2;
                PlayerPrefs.SetInt("Hotel_bild", Hotel_bild);
                PlayerPrefs.Save();
                Button_Hotel_bild_1.SetActive(false);
                Button_Hotel_bild_2.SetActive(true);
                Hotel_bild_prefab.SetActive(true);
                DateTime start_Hotel = DateTime.Now;

                if (PlayerPrefs.HasKey("start_Hotel"))
                    start_Hotel = DateTime.Parse(PlayerPrefs.GetString("start_Hotel"));
                else
                    PlayerPrefs.SetString("start_Hotel", start_Hotel.ToString());
                StartCoroutine(timer_Hotel(start_Hotel));
            }
        }
        else
        {
            panelBox.SetActive(true);
        }
            //int loadsum = PlayerPrefs.GetInt("summ");
            //summ = loadsum;
            //textSum.text = summ.ToString();
            int Hotel_load = PlayerPrefs.GetInt("Hotel_bild");
            Hotel_bild = Hotel_load;
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
    IEnumerator timer_Hotel(DateTime start_Hotel)
    {
        DateTime end = start_Hotel.AddMinutes(60);
        while (DateTime.Now < end)
        {
            TimeSpan remaining = end - DateTime.Now;
            if (remaining.TotalSeconds > 1)
            {
                countdown_Hotel.text = remaining.ToString("''m' : 's''");
                Debug.Log(remaining + " - countdown_Hotel");   
            }
            yield return new WaitForSeconds(1f); 
        }
        Hotel_bild_prefab.SetActive(false);
        Hotel_buy = 2;
        PlayerPrefs.SetInt("Hotel_buy", Hotel_buy);
        PlayerPrefs.Save();
        Timer_Hotel.SetActive(false);
        Hotel_prefab.SetActive(true); 
    }


}