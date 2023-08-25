using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class police_buy : MonoBehaviour
{   
    private int Police_buy;
    private int Police_bild;

    private DateTime start_Police = DateTime.Now;
    private float time = 60;
    private string nameprice;
    private int price;
    private string userid;
    private string loadusers;
    
    public string nameBuy;
    public int summ;
    public Text textSum;
    public TextMesh countdown_Police;
    public GameObject Timer_Police;

    [SerializeField]
    GameObject Police_prefab, Police_bild_prefab;

    [SerializeField]
    GameObject Button_Police_bild_1, Button_Police_bild_2;

    [SerializeField]
    public GameObject panelBox, sales;

    public GameObject spawn_police_car;

    void Start()
    {
        //summ;
        int summ = PlayerPrefs.GetInt("summ");
        textSum.text = summ.ToString();

        int Police_bild = PlayerPrefs.GetInt("Police_bild");
        if (Police_bild == 2)
        {
            Button_Police_bild_1.SetActive(false);
            Button_Police_bild_2.SetActive(true); 
            Police_bild_prefab.SetActive(true);
            if (PlayerPrefs.HasKey("start_Police"))
                start_Police = DateTime.Parse(PlayerPrefs.GetString("start_Police"));
            else
                PlayerPrefs.SetString("start_Police", start_Police.ToString());
            StartCoroutine(timer_Police(start_Police));

        }
        
        int Police_buy = PlayerPrefs.GetInt("Police_buy");
        if (Police_buy == 2)
        {
            Police_bild = 3;
            PlayerPrefs.SetInt("Police_bild", Police_bild);
            Police_bild_prefab.SetActive(false);
            Police_prefab.SetActive(true);
            Button_Police_bild_1.SetActive(false);
            Button_Police_bild_2.SetActive(true); 
        }
    }
    void Update()
    {

        int loadsum = PlayerPrefs.GetInt("summ");
        summ = loadsum;
        textSum.text = summ.ToString();

        int Police_load = PlayerPrefs.GetInt("Police_bild");
        Police_bild = Police_load;
        if(Police_bild == 2)
        { 
            Debug.Log("Строиться");
        }

        int Police_buy_load = PlayerPrefs.GetInt("Police_buy");
        Police_buy = Police_buy_load;
        if(Police_buy == 2)
        { 
            spawn_police_car.SetActive(true);
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
    
    public void BuyStorePolice()
    {
        nameBuy = "Police";
        BuyStore();
    }
    public void BuyStore()
    {

        if (nameBuy == "Police" && summ >= 500)
        {
            if (Police_bild == 2 || Police_bild == 3) 
            {
                sales.SetActive(true);
            }
            else
            {
                string loadusers = PlayerPrefs.GetString("userid");
                userid = loadusers;
                nameprice = "Police";
                price = 500;
                StartCoroutine(BuyProduct());
                summ-=500;
                PlayerPrefs.SetInt("summ", summ);
                Police_bild = 2;
                PlayerPrefs.SetInt("Police_bild", Police_bild);
                PlayerPrefs.Save();
                Button_Police_bild_1.SetActive(false);
                Button_Police_bild_2.SetActive(true);
                Police_bild_prefab.SetActive(true);
                DateTime start_Police = DateTime.Now;

                if (PlayerPrefs.HasKey("start_Police"))
                    start_Police = DateTime.Parse(PlayerPrefs.GetString("start_Police"));
                else
                    PlayerPrefs.SetString("start_Police", start_Police.ToString());
                StartCoroutine(timer_Police(start_Police));
            }
        }
        else
        {
            panelBox.SetActive(true);
        }
            //int loadsum = PlayerPrefs.GetInt("summ");
            //summ = loadsum;
            //textSum.text = summ.ToString();
            int Police_load = PlayerPrefs.GetInt("Police_bild");
            Police_bild = Police_load;
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
    IEnumerator timer_Police(DateTime start_Police)
    {
        DateTime end = start_Police.AddMinutes(30);
        while (DateTime.Now < end)
        {
            TimeSpan remaining = end - DateTime.Now;
            if (remaining.TotalSeconds > 1)
            {
                countdown_Police.text = remaining.ToString("''m' : 's''");
                Debug.Log(remaining + " - countdown_Police");   
            }
            yield return new WaitForSeconds(1f); 
        }
        Police_bild_prefab.SetActive(false);
        Police_buy = 2;
        PlayerPrefs.SetInt("Police_buy", Police_buy);
        PlayerPrefs.Save();
        Timer_Police.SetActive(false);
        Police_prefab.SetActive(true); 
    }


}