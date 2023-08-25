using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class bank_buy : MonoBehaviour
{   
    private int Bank_buy;
    private int Bank_bild;

    private DateTime start_bank = DateTime.Now;
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
    public TextMesh countdown_bank;
    public GameObject Timer_bank;

    [SerializeField]
    GameObject Bank_prefab, Bank_bild_prefab;

    [SerializeField]
    GameObject Button_Bank_bild_1, Button_Bank_bild_2;

    [SerializeField]
    public GameObject panelBox, sales;

    void Start()
    {
        //summ;
        int summ = PlayerPrefs.GetInt("summ");
        textSum.text = summ.ToString();
        int briliant = PlayerPrefs.GetInt("briliant");
        textBriliant.text = briliant.ToString();
        panelBox.SetActive(false);
        sales.SetActive(false);

        int Bank_bild = PlayerPrefs.GetInt("Bank_bild");
        if (Bank_bild == 2)
        {
            Button_Bank_bild_1.SetActive(false);
            Button_Bank_bild_2.SetActive(true); 
            Bank_bild_prefab.SetActive(true);

            if (PlayerPrefs.HasKey("start_bank"))
                start_bank = DateTime.Parse(PlayerPrefs.GetString("start_bank"));
            else
                PlayerPrefs.SetString("start_bank", start_bank.ToString());
            StartCoroutine(timer_bank(start_bank));

        }
        
        int Bank_buy = PlayerPrefs.GetInt("Bank_buy");
        if (Bank_buy == 2)
        {
            Bank_bild = 3;
            PlayerPrefs.SetInt("Bank_bild", Bank_bild);
            Bank_bild_prefab.SetActive(false);
            Bank_prefab.SetActive(true);
            Button_Bank_bild_1.SetActive(false);
            Button_Bank_bild_2.SetActive(true); 
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

        int Bank_load = PlayerPrefs.GetInt("Bank_bild");
        Bank_bild = Bank_load;
        if(Bank_bild == 2)
        { 
            Debug.Log("Строиться");
        }

        int Bank_buy_load = PlayerPrefs.GetInt("Bank_buy");
        Bank_buy = Bank_buy_load;
        if(Bank_buy == 2)
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

    
    public void BuyStoreBank()
    {
        nameBuy = "Bank";
        BuyStore();
    }
    public void BuyStore()
    {

        if (nameBuy == "Bank" && summ >= 1000)
        {
            if (Bank_bild == 2 || Bank_bild == 3) 
            {
                sales.SetActive(true);
            }
            else
            {
                string loadusers = PlayerPrefs.GetString("userid");
                userid = loadusers;
                nameprice = "Bank";
                price = 1000;
                StartCoroutine(BuyProduct());
                summ-=1000;
                PlayerPrefs.SetInt("summ", summ);
                Bank_bild = 2;
                PlayerPrefs.SetInt("Bank_bild", Bank_bild);
                PlayerPrefs.Save();
                Button_Bank_bild_1.SetActive(false);
                Button_Bank_bild_2.SetActive(true);
                Bank_bild_prefab.SetActive(true);
                DateTime start_bank = DateTime.Now;

                if (PlayerPrefs.HasKey("start_bank"))
                    start_bank = DateTime.Parse(PlayerPrefs.GetString("start_bank"));
                else
                    PlayerPrefs.SetString("start_bank", start_bank.ToString());
                StartCoroutine(timer_bank(start_bank));
            }
        }
        else
        {
            panelBox.SetActive(true);
        }
            //int loadsum = PlayerPrefs.GetInt("summ");
            //summ = loadsum;
            //textSum.text = summ.ToString();
            int Bank_load = PlayerPrefs.GetInt("Bank_bild");
            Bank_bild = Bank_load;
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
    IEnumerator timer_bank(DateTime start_bank)
    {
        DateTime end = start_bank.AddMinutes(60);
        while (DateTime.Now < end)
        {
            TimeSpan remaining = end - DateTime.Now;
            if (remaining.TotalSeconds > 1)
            {
                countdown_bank.text = remaining.ToString("''m' : 's''");
                Debug.Log(remaining + " - countdown_bank");   
            }
            yield return new WaitForSeconds(1f); 
        }
        Bank_bild_prefab.SetActive(false);
        Bank_buy = 2;
        PlayerPrefs.SetInt("Bank_buy", Bank_buy);
        PlayerPrefs.Save();
        Timer_bank.SetActive(false);
        Bank_prefab.SetActive(true); 
    }


}