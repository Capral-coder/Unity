using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class cinema_buy : MonoBehaviour
{   
    private int Cinema_buy;
    private int Cinema_bild;

    private DateTime start_Cinema = DateTime.Now;
    private float time = 60;
    private string nameprice;
    private int price;
    private string userid;
    private string loadusers;
    
    public string nameBuy;
    public int summ;
    public Text textSum;
    public TextMesh countdown_Cinema;
    public GameObject Timer_Cinema;

    [SerializeField]
    GameObject Cinema_prefab, Cinema_bild_prefab;

    [SerializeField]
    GameObject Button_Cinema_bild_1, Button_Cinema_bild_2;

    [SerializeField]
    public GameObject panelBox, sales;

    void Start()
    {
        //summ;
        int summ = PlayerPrefs.GetInt("summ");
        textSum.text = summ.ToString();
        panelBox.SetActive(false);
        sales.SetActive(false);

        int Cinema_bild = PlayerPrefs.GetInt("Cinema_bild");
        if (Cinema_bild == 2)
        {
            Button_Cinema_bild_1.SetActive(false);
            Button_Cinema_bild_2.SetActive(true); 
            Cinema_bild_prefab.SetActive(true);

            if (PlayerPrefs.HasKey("start_Cinema"))
                start_Cinema = DateTime.Parse(PlayerPrefs.GetString("start_Cinema"));
            else
                PlayerPrefs.SetString("start_Cinema", start_Cinema.ToString());
            StartCoroutine(timer_Cinema(start_Cinema));

        }
        
        int Cinema_buy = PlayerPrefs.GetInt("Cinema_buy");
        if (Cinema_buy == 2)
        {
            Cinema_bild = 3;
            PlayerPrefs.SetInt("Cinema_bild", Cinema_bild);
            Cinema_bild_prefab.SetActive(false);
            Cinema_prefab.SetActive(true);
            Button_Cinema_bild_1.SetActive(false);
            Button_Cinema_bild_2.SetActive(true); 
        }
    }
    void Update()
    {

        int loadsum = PlayerPrefs.GetInt("summ");
        summ = loadsum;
        textSum.text = summ.ToString();

        int Cinema_load = PlayerPrefs.GetInt("Cinema_bild");
        Cinema_bild = Cinema_load;
        if(Cinema_bild == 2)
        { 
            Debug.Log("Строиться");
        }

        int Cinema_buy_load = PlayerPrefs.GetInt("Cinema_buy");
        Cinema_buy = Cinema_buy_load;
        if(Cinema_buy == 2)
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

    
    public void BuyStoreCinema()
    {
        nameBuy = "Cinema";
        BuyStore();
    }
    public void BuyStore()
    {

        if (nameBuy == "Cinema" && summ >= 400)
        {
            if (Cinema_bild == 2 || Cinema_bild == 3) 
            {
                sales.SetActive(true);
            }
            else
            {
                string loadusers = PlayerPrefs.GetString("userid");
                userid = loadusers;
                nameprice = "Cinema";
                price = 400;
                StartCoroutine(BuyProduct());
                summ-=400;
                PlayerPrefs.SetInt("summ", summ);
                Cinema_bild = 2;
                PlayerPrefs.SetInt("Cinema_bild", Cinema_bild);
                PlayerPrefs.Save();
                Button_Cinema_bild_1.SetActive(false);
                Button_Cinema_bild_2.SetActive(true);
                Cinema_bild_prefab.SetActive(true);
                DateTime start_Cinema = DateTime.Now;

                if (PlayerPrefs.HasKey("start_Cinema"))
                    start_Cinema = DateTime.Parse(PlayerPrefs.GetString("start_Cinema"));
                else
                    PlayerPrefs.SetString("start_Cinema", start_Cinema.ToString());
                StartCoroutine(timer_Cinema(start_Cinema));
            }
        }
        else
        {
            panelBox.SetActive(true);
        }
            //int loadsum = PlayerPrefs.GetInt("summ");
            //summ = loadsum;
            //textSum.text = summ.ToString();
            int Cinema_load = PlayerPrefs.GetInt("Cinema_bild");
            Cinema_bild = Cinema_load;
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
    IEnumerator timer_Cinema(DateTime start_Cinema)
    {
        DateTime end = start_Cinema.AddMinutes(60);
        while (DateTime.Now < end)
        {
            TimeSpan remaining = end - DateTime.Now;
            if (remaining.TotalSeconds > 1)
            {
                countdown_Cinema.text = remaining.ToString("''m' : 's''");
                Debug.Log(remaining + " - countdown_Cinema");   
            }
            yield return new WaitForSeconds(1f); 
        }
        Cinema_bild_prefab.SetActive(false);
        Cinema_buy = 2;
        PlayerPrefs.SetInt("Cinema_buy", Cinema_buy);
        PlayerPrefs.Save();
        Timer_Cinema.SetActive(false);
        Cinema_prefab.SetActive(true); 
    }


}