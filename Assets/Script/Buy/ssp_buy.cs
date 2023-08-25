using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ssp_buy : MonoBehaviour
{   
    private int SSP_buy;
    private int SSP_bild;

    private DateTime start_SSP = DateTime.Now;
    private float time_briliant = 300;
    private float time = 60;
    private string nameprice;
    private int price;
    private string userid;
    private string loadusers;
    
    public string nameBuy;
    public int summ;
    public Text textSum;
    public int briliant;
    public Text textBriliant;
    public TextMesh countdown_SSP;
    public GameObject Timer_SSP;

    [SerializeField]
    GameObject SSP_prefab, SSP_bild_prefab;

    [SerializeField]
    GameObject Button_SSP_bild_1, Button_SSP_bild_2;

    [SerializeField]
    public GameObject ButStore,ButStore2,ButStore3,panelBox, sales;

    void Start()
    {
        //summ;
        int summ = PlayerPrefs.GetInt("summ");
        textSum.text = summ.ToString();
        int briliant = PlayerPrefs.GetInt("briliant");
        textBriliant.text = briliant.ToString();

        int SSP_bild = PlayerPrefs.GetInt("SSP_bild");
        if (SSP_bild == 2)
        {
            Button_SSP_bild_1.SetActive(false);
            Button_SSP_bild_2.SetActive(true); 
            SSP_bild_prefab.SetActive(true);
            if (PlayerPrefs.HasKey("start_SSP"))
                start_SSP = DateTime.Parse(PlayerPrefs.GetString("start_SSP"));
            else
                PlayerPrefs.SetString("start_SSP", start_SSP.ToString());
            StartCoroutine(timer_SSP(start_SSP));

        }
        
        int SSP_buy = PlayerPrefs.GetInt("SSP_buy");
        if (SSP_buy == 2)
        {
            SSP_bild = 3;
            PlayerPrefs.SetInt("SSP_bild", SSP_bild);
            SSP_bild_prefab.SetActive(false);
            SSP_prefab.SetActive(true);
            Button_SSP_bild_1.SetActive(false);
            Button_SSP_bild_2.SetActive(true); 
        }
    }
    void Update()
    {

        int loadsum = PlayerPrefs.GetInt("summ");
        summ = loadsum;
        textSum.text = summ.ToString();

        int loadbriliant = PlayerPrefs.GetInt("briliant");
        briliant = loadbriliant;
        textBriliant.text = briliant.ToString();

        int SSP_load = PlayerPrefs.GetInt("SSP_bild");
        SSP_bild = SSP_load;
        if(SSP_bild == 2)
        { 
            Debug.Log("Строиться");
        }

        int SSP_buy_load = PlayerPrefs.GetInt("SSP_buy");
        SSP_buy = SSP_buy_load;
        if(SSP_buy == 2)
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
            time_briliant -= Time.deltaTime;
            if(time_briliant <= 0)
            {
                briliant+=1;
                PlayerPrefs.SetInt("briliant", briliant);
                PlayerPrefs.Save();
                Debug.Log("Прошло 5 мин!");
                time_briliant = 10f;
            }
        }
    }
    
    public void BuyStoreSSP()
    {
        nameBuy = "SSP";
        BuyStore();
    }
    public void BuyStore()
    {

        if (nameBuy == "SSP" && summ >= 1000)
        {
            if (SSP_bild == 2 || SSP_bild == 3) 
            {
                sales.SetActive(true);
            }
            else
            {
                string loadusers = PlayerPrefs.GetString("userid");
                userid = loadusers;
                nameprice = "SSP";
                price = 1000;
                StartCoroutine(BuyProduct());
                summ-=1000;
                PlayerPrefs.SetInt("summ", summ);
                SSP_bild = 2;
                PlayerPrefs.SetInt("SSP_bild", SSP_bild);
                PlayerPrefs.Save();
                Button_SSP_bild_1.SetActive(false);
                Button_SSP_bild_2.SetActive(true);
                SSP_bild_prefab.SetActive(true);
                DateTime start_SSP = DateTime.Now;

                if (PlayerPrefs.HasKey("start_SSP"))
                    start_SSP = DateTime.Parse(PlayerPrefs.GetString("start_SSP"));
                else
                    PlayerPrefs.SetString("start_SSP", start_SSP.ToString());
                StartCoroutine(timer_SSP(start_SSP));
            }
        }
        else
        {
            panelBox.SetActive(true);
        }
            //int loadsum = PlayerPrefs.GetInt("summ");
            //summ = loadsum;
            //textSum.text = summ.ToString();
            int SSP_load = PlayerPrefs.GetInt("SSP_bild");
            SSP_bild = SSP_load;
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
    IEnumerator timer_SSP(DateTime start_SSP)
    {
        DateTime end = start_SSP.AddMinutes(60);
        while (DateTime.Now < end)
        {
            TimeSpan remaining = end - DateTime.Now;
            if (remaining.TotalSeconds > 1)
            {
                countdown_SSP.text = remaining.ToString("''m' : 's''");
                Debug.Log(remaining + " - countdown_SSP");   
            }
            yield return new WaitForSeconds(1f); 
        }
        SSP_bild_prefab.SetActive(false);
        SSP_buy = 2;
        PlayerPrefs.SetInt("SSP_buy", SSP_buy);
        PlayerPrefs.Save();
        Timer_SSP.SetActive(false);
        SSP_prefab.SetActive(true); 
    }


}