using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class office_buy : MonoBehaviour
{   
    private int Office_buy;
    private int Office_bild;
    private int Office_buy_2;
    private int Office_bild_2;

    private DateTime start_Office = DateTime.Now;
    private float time = 60;
    private DateTime start_Office_2 = DateTime.Now;
    private float time_2 = 60;
    private string nameprice;
    private int price;
    private string userid;
    private string loadusers;
    
    public string nameBuy;
    public int summ;
    public Text textSum;
    public TextMesh countdown_Office;
    public GameObject Timer_Office;

    public TextMesh countdown_Office_2;
    public GameObject Timer_Office_2;

    [SerializeField]
    GameObject Office_prefab, Office_bild_prefab, Office_prefab_2, Office_bild_prefab_2 ;

    [SerializeField]
    GameObject Button_Office_bild_1, Button_Office_bild_2, Button_Office_bild_3;

    [SerializeField]
    public GameObject panelBox, sales;

    void Start()
    {
        //summ;
        int summ = PlayerPrefs.GetInt("summ");
        textSum.text = summ.ToString();
        panelBox.SetActive(false);
        sales.SetActive(false);

        int Office_bild = PlayerPrefs.GetInt("Office_bild");
        if (Office_bild == 2)
        {
            Button_Office_bild_1.SetActive(false);
            Button_Office_bild_2.SetActive(true); 
            Office_bild_prefab.SetActive(true);
            if (PlayerPrefs.HasKey("start_Office"))
                start_Office = DateTime.Parse(PlayerPrefs.GetString("start_Office"));
            else
                PlayerPrefs.SetString("start_Office", start_Office.ToString());
            StartCoroutine(timer_Office(start_Office));

        }
        
        int Office_buy = PlayerPrefs.GetInt("Office_buy");
        if (Office_buy == 2)
        {
            Office_bild = 3;
            PlayerPrefs.SetInt("Office_bild", Office_bild);
            Office_bild_prefab.SetActive(false);
            Office_prefab.SetActive(true);
            Button_Office_bild_1.SetActive(false);
            Button_Office_bild_2.SetActive(true); 
        }

        int Office_bild_2 = PlayerPrefs.GetInt("Office_bild_2");
        if (Office_bild_2 == 2)
        {
            Button_Office_bild_2.SetActive(false);
            Button_Office_bild_3.SetActive(true); 
            Office_bild_prefab_2.SetActive(true);
            if (PlayerPrefs.HasKey("start_Office_2"))
                start_Office_2 = DateTime.Parse(PlayerPrefs.GetString("start_Office_2"));
            else
                PlayerPrefs.SetString("start_Office_2", start_Office_2.ToString());
            StartCoroutine(timer_Office_2(start_Office_2));

        }
        
        int Office_buy_2 = PlayerPrefs.GetInt("Office_buy_2");
        if (Office_buy_2 == 2)
        {
            Office_bild_2 = 3;
            PlayerPrefs.SetInt("Office_bild_2", Office_bild_2);
            Office_bild_prefab_2.SetActive(false);
            Office_prefab_2.SetActive(true);
            Button_Office_bild_2.SetActive(false);
            Button_Office_bild_3.SetActive(true); 
        }
    }
    void Update()
    {

        int loadsum = PlayerPrefs.GetInt("summ");
        summ = loadsum;
        textSum.text = summ.ToString();


        int Office_load = PlayerPrefs.GetInt("Office_bild");
        Office_bild = Office_load;
        if(Office_bild == 2)
        { 
            Debug.Log("Строиться");
        }

        int Office_buy_load = PlayerPrefs.GetInt("Office_buy");
        Office_buy = Office_buy_load;
        if(Office_buy == 2)
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
        int Office_buy_load_2 = PlayerPrefs.GetInt("Office_buy_2");
        Office_buy_2 = Office_buy_load_2;
        if(Office_buy_2 == 2)
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
  
    public void BuyStoreOffice()
    {
        nameBuy = "Office";
        BuyStore();
    }

    public void BuyStoreOffice_2()
    {
        nameBuy = "Office_2";
        BuyStore();
    }
    public void BuyStore()
    {

        if (nameBuy == "Office" && summ >= 400)
        {
            if (Office_bild == 2 || Office_bild == 3) 
            {
                sales.SetActive(true);
            }
            else
            {
                string loadusers = PlayerPrefs.GetString("userid");
                userid = loadusers;
                nameprice = "Office";
                price = 400;
                StartCoroutine(BuyProduct());
                summ-=400;
                PlayerPrefs.SetInt("summ", summ);
                Office_bild = 2;
                PlayerPrefs.SetInt("Office_bild", Office_bild);
                PlayerPrefs.Save();
                Button_Office_bild_1.SetActive(false);
                Button_Office_bild_2.SetActive(true);
                Office_bild_prefab.SetActive(true);
                DateTime start_Office = DateTime.Now;

                if (PlayerPrefs.HasKey("start_Office"))
                    start_Office = DateTime.Parse(PlayerPrefs.GetString("start_Office"));
                else
                    PlayerPrefs.SetString("start_Office", start_Office.ToString());
                StartCoroutine(timer_Office(start_Office));
            }
        }

        else if (nameBuy == "Office_2" && summ >= 400)
        {
            if (Office_bild_2 == 2 || Office_bild == 3) 
            {
                sales.SetActive(true);
            }
            else
            {
                string loadusers = PlayerPrefs.GetString("userid");
                userid = loadusers;
                nameprice = "Office_2";
                price = 400;
                StartCoroutine(BuyProduct());
                summ-=400;
                PlayerPrefs.SetInt("summ", summ);
                Office_bild_2 = 2;
                PlayerPrefs.SetInt("Office_bild_2", Office_bild_2);
                PlayerPrefs.Save();
                Button_Office_bild_2.SetActive(false);
                Button_Office_bild_3.SetActive(true);
                Office_bild_prefab_2.SetActive(true);
                DateTime start_Office_2 = DateTime.Now;

                if (PlayerPrefs.HasKey("start_Office_2"))
                    start_Office_2 = DateTime.Parse(PlayerPrefs.GetString("start_Office_2"));
                else
                    PlayerPrefs.SetString("start_Office_2", start_Office_2.ToString());
                StartCoroutine(timer_Office_2(start_Office_2));
            }
        }

        else
        {
            panelBox.SetActive(true);
        }
            //int loadsum = PlayerPrefs.GetInt("summ");
            //summ = loadsum;
            //textSum.text = summ.ToString();
            int Office_load = PlayerPrefs.GetInt("Office_bild");
            Office_bild = Office_load;

            int Office_load_2 = PlayerPrefs.GetInt("Office_bild_2");
            Office_bild_2 = Office_load_2;
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
    IEnumerator timer_Office(DateTime start_Office)
    {
        DateTime end = start_Office.AddMinutes(20);
        while (DateTime.Now < end)
        {
            TimeSpan remaining = end - DateTime.Now;
            if (remaining.TotalSeconds > 1)
            {
                countdown_Office.text = remaining.ToString("''m' : 's''");
                Debug.Log(remaining + " - countdown_Office");   
            }
            yield return new WaitForSeconds(1f); 
        }
        Office_bild_prefab.SetActive(false);
        Office_buy = 2;
        PlayerPrefs.SetInt("Office_buy", Office_buy);
        PlayerPrefs.Save();
        Timer_Office.SetActive(false);
        Office_prefab.SetActive(true); 
    }

    IEnumerator timer_Office_2(DateTime start_Office_2)
    {
        DateTime end = start_Office_2.AddMinutes(20);
        while (DateTime.Now < end)
        {
            TimeSpan remaining = end - DateTime.Now;
            if (remaining.TotalSeconds > 1)
            {
                countdown_Office_2.text = remaining.ToString("''m' : 's''");
                Debug.Log(remaining + " - countdown_Office_2");   
            }
            yield return new WaitForSeconds(1f); 
        }
        Office_bild_prefab_2.SetActive(false);
        Office_buy_2 = 2;
        PlayerPrefs.SetInt("Office_buy_2", Office_buy_2);
        PlayerPrefs.Save();
        Timer_Office_2.SetActive(false);
        Office_prefab_2.SetActive(true); 
    }


}