using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class shop_buy : MonoBehaviour
{   
    private int Shop_buy;
    private int Shop_bild;

    private DateTime start_Shop = DateTime.Now;
    private float time = 60;
    private string nameprice;
    private int price;
    private string userid;
    private string loadusers;
    
    public string nameBuy;
    public int summ;
    public Text textSum;
    public TextMesh countdown_Shop;
    public GameObject Timer_Shop;

    [SerializeField]
    GameObject Shop_prefab, Shop_bild_prefab;

    [SerializeField]
    GameObject Button_Shop_bild_1, Button_Shop_bild_2;

    [SerializeField]
    public GameObject panelBox, sales;

    void Start()
    {
        //summ;
        int summ = PlayerPrefs.GetInt("summ");
        textSum.text = summ.ToString();

        int Shop_bild = PlayerPrefs.GetInt("Shop_bild");
        if (Shop_bild == 2)
        {
            Button_Shop_bild_1.SetActive(false);
            Button_Shop_bild_2.SetActive(true); 
            Shop_bild_prefab.SetActive(true);             
            if (PlayerPrefs.HasKey("start_Shop"))
                start_Shop = DateTime.Parse(PlayerPrefs.GetString("start_Shop"));
            else
                PlayerPrefs.SetString("start_Shop", start_Shop.ToString());
            StartCoroutine(timer_Shop(start_Shop));

        }
        
        int Shop_buy = PlayerPrefs.GetInt("Shop_buy");
        if (Shop_buy == 2)
        {
            Button_Shop_bild_1.SetActive(false);
            Button_Shop_bild_2.SetActive(true); 
            Shop_bild = 3;
            PlayerPrefs.SetInt("Shop_bild", Shop_bild);
            Shop_bild_prefab.SetActive(false);
            Shop_prefab.SetActive(true);
        }
    }
    void Update()
    {

        int loadsum = PlayerPrefs.GetInt("summ");
        summ = loadsum;
        textSum.text = summ.ToString();

        int Shop_buy_load = PlayerPrefs.GetInt("Shop_buy");
        Shop_buy = Shop_buy_load;
        if(Shop_buy == 2)
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
    
    public void BuyStoreShop()
    {
        nameBuy = "Shop";
        BuyStore();
    }
    public void BuyStore()
    {

        if (nameBuy == "Shop" && summ >= 600)
        {
            if (Shop_bild == 2 || Shop_bild == 3) 
            {
                sales.SetActive(true);
            }
            else
            {
                string loadusers = PlayerPrefs.GetString("userid");
                userid = loadusers;
                nameprice = "Shop";
                price = 600;
                StartCoroutine(BuyProduct());
                summ-=600;
                PlayerPrefs.SetInt("summ", summ);
                Shop_bild = 2;
                PlayerPrefs.SetInt("Shop_bild", Shop_bild);
                PlayerPrefs.Save();
                Button_Shop_bild_1.SetActive(false);
                Button_Shop_bild_2.SetActive(true);
                Shop_bild_prefab.SetActive(true);
                DateTime start_Shop = DateTime.Now;

                if (PlayerPrefs.HasKey("start_Shop"))
                    start_Shop = DateTime.Parse(PlayerPrefs.GetString("start_Shop"));
                else
                    PlayerPrefs.SetString("start_Shop", start_Shop.ToString());
                StartCoroutine(timer_Shop(start_Shop));
            }
        }
        else
        {
            panelBox.SetActive(true);
        }
            //int loadsum = PlayerPrefs.GetInt("summ");
            //summ = loadsum;
            //textSum.text = summ.ToString();
            int Shop_load = PlayerPrefs.GetInt("Shop_bild");
            Shop_bild = Shop_load;
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
    IEnumerator timer_Shop(DateTime start_Shop)
    {
        DateTime end = start_Shop.AddMinutes(40);
        while (DateTime.Now < end)
        {
            TimeSpan remaining = end - DateTime.Now;
            if (remaining.TotalSeconds > 1)
            {
                countdown_Shop.text = remaining.ToString("''m' : 's''");
                Debug.Log(remaining + " - countdown_Shop");   
            }
            yield return new WaitForSeconds(1f); 
        }
        Shop_bild_prefab.SetActive(false);
        Shop_buy = 2;
        PlayerPrefs.SetInt("Shop_buy", Shop_buy);
        PlayerPrefs.Save();
        Timer_Shop.SetActive(false);
        Shop_prefab.SetActive(true); 
    }


}