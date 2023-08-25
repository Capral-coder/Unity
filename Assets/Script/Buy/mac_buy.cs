using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class mac_buy : MonoBehaviour
{   
    private int Mac_buy;
    private int Mac_bild;

    private DateTime start_Mac = DateTime.Now;
    private float time = 60;
    private string nameprice;
    private int price;
    private string userid;
    private string loadusers;
    
    public string nameBuy;
    public int summ;
    public Text textSum;
    public TextMesh countdown_Mac;
    public GameObject Timer_Mac;

    [SerializeField]
    GameObject Mac_prefab, Mac_bild_prefab;

    [SerializeField]
    GameObject Button_Mac_bild_1, Button_Mac_bild_2;

    [SerializeField]
    public GameObject panelBox, sales;

    void Start()
    {
        //summ;
        int summ = PlayerPrefs.GetInt("summ");
        textSum.text = summ.ToString();
        panelBox.SetActive(false);
        sales.SetActive(false);

        int Mac_bild = PlayerPrefs.GetInt("Mac_bild");
        if (Mac_bild == 2)
        {
            Button_Mac_bild_1.SetActive(false);
            Button_Mac_bild_2.SetActive(true); 
            Mac_bild_prefab.SetActive(true);

            if (PlayerPrefs.HasKey("start_Mac"))
                start_Mac = DateTime.Parse(PlayerPrefs.GetString("start_Mac"));
            else
                PlayerPrefs.SetString("start_Mac", start_Mac.ToString());
            StartCoroutine(timer_Mac(start_Mac));

        }
        
        int Mac_buy = PlayerPrefs.GetInt("Mac_buy");
        if (Mac_buy == 2)
        {
            Mac_bild = 3;
            PlayerPrefs.SetInt("Mac_bild", Mac_bild);
            Mac_bild_prefab.SetActive(false);
            Mac_prefab.SetActive(true);
            Button_Mac_bild_1.SetActive(false);
            Button_Mac_bild_2.SetActive(true); 
        }
    }
    void Update()
    {

        int loadsum = PlayerPrefs.GetInt("summ");
        summ = loadsum;
        textSum.text = summ.ToString();


        int Mac_load = PlayerPrefs.GetInt("Mac_bild");
        Mac_bild = Mac_load;
        if(Mac_bild == 2)
        { 
            Debug.Log("Строиться");
        }

        int Mac_buy_load = PlayerPrefs.GetInt("Mac_buy");
        Mac_buy = Mac_buy_load;
        if(Mac_buy == 2)
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
  
    public void BuyStoreMac()
    {
        nameBuy = "Mac";
        BuyStore();
    }
    public void BuyStore()
    {

        if (nameBuy == "Mac" && summ >= 500)
        {
            if (Mac_bild == 2 || Mac_bild == 3) 
            {
                sales.SetActive(true);
            }
            else
            {
                string loadusers = PlayerPrefs.GetString("userid");
                userid = loadusers;
                nameprice = "Mac";
                price = 500;
                StartCoroutine(BuyProduct());
                summ-=500;
                PlayerPrefs.SetInt("summ", summ);
                Mac_bild = 2;
                PlayerPrefs.SetInt("Mac_bild", Mac_bild);
                PlayerPrefs.Save();
                Button_Mac_bild_1.SetActive(false);
                Button_Mac_bild_2.SetActive(true);
                Mac_bild_prefab.SetActive(true);

                DateTime start_Mac = DateTime.Now;      
                if (PlayerPrefs.HasKey("start_Mac"))
                    start_Mac = DateTime.Parse(PlayerPrefs.GetString("start_Mac"));
                else
                    PlayerPrefs.SetString("start_Mac", start_Mac.ToString());
                StartCoroutine(timer_Mac(start_Mac));
            }
        }
        else
        {
            panelBox.SetActive(true);
        }
            //int loadsum = PlayerPrefs.GetInt("summ");
            //summ = loadsum;
            //textSum.text = summ.ToString();
            int Mac_load = PlayerPrefs.GetInt("Mac_bild");
            Mac_bild = Mac_load;
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
    IEnumerator timer_Mac(DateTime start_Mac)
    {
        DateTime end = start_Mac.AddMinutes(30);
        while (DateTime.Now < end)
        {
            TimeSpan remaining = end - DateTime.Now;
            if (remaining.TotalSeconds > 1)
            {
                countdown_Mac.text = remaining.ToString("''m' : 's''");
                Debug.Log(remaining + " - countdown_Mac");   
            }
            yield return new WaitForSeconds(1f); 
        }
        Mac_bild_prefab.SetActive(false);
        Mac_buy = 2;
        PlayerPrefs.SetInt("Mac_buy", Mac_buy);
        PlayerPrefs.Save();
        Timer_Mac.SetActive(false);
        Mac_prefab.SetActive(true); 
    }


}