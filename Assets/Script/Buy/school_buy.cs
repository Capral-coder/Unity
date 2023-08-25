using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class school_buy : MonoBehaviour
{   
    private int School_buy;
    private int School_bild;

    private DateTime start_School = DateTime.Now;
    private float time = 60;
    private string nameprice;
    private int price;
    private string userid;
    private string loadusers;
    
    public string nameBuy;
    public int summ;
    public Text textSum;
    public TextMesh countdown_School;
    public GameObject Timer_School;

    [SerializeField]
    GameObject School_prefab, School_bild_prefab;

    [SerializeField]
    GameObject Button_School_bild_1, Button_School_bild_2;

    [SerializeField]
    public GameObject panelBox, sales;

    void Start()
    {
        //summ;
        int summ = PlayerPrefs.GetInt("summ");
        textSum.text = summ.ToString();
        panelBox.SetActive(false);
        sales.SetActive(false);

        int School_bild = PlayerPrefs.GetInt("School_bild");
        if (School_bild == 2)
        {
            Button_School_bild_1.SetActive(false);
            Button_School_bild_2.SetActive(true); 
            School_bild_prefab.SetActive(true);

            if (PlayerPrefs.HasKey("start_School"))
                start_School = DateTime.Parse(PlayerPrefs.GetString("start_School"));
            else
                PlayerPrefs.SetString("start_School", start_School.ToString());
            StartCoroutine(timer_School(start_School));

        }
        
        int School_buy = PlayerPrefs.GetInt("School_buy");
        if (School_buy == 2)
        {
            School_bild = 3;
            PlayerPrefs.SetInt("School_bild", School_bild);
            School_bild_prefab.SetActive(false);
            School_prefab.SetActive(true);
            Button_School_bild_1.SetActive(false);
            Button_School_bild_2.SetActive(true); 
        }
    }
    void Update()
    {

        int loadsum = PlayerPrefs.GetInt("summ");
        summ = loadsum;
        textSum.text = summ.ToString();

        int School_load = PlayerPrefs.GetInt("School_bild");
        School_bild = School_load;
        if(School_bild == 2)
        { 
            Debug.Log("Строиться");
        }

        int School_buy_load = PlayerPrefs.GetInt("School_buy");
        School_buy = School_buy_load;
        if(School_buy == 2)
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

    
    public void BuyStoreSchool()
    {
        nameBuy = "School";
        BuyStore();
    }
    public void BuyStore()
    {

        if (nameBuy == "School" && summ >= 400)
        {
            if (School_bild == 2 || School_bild == 3) 
            {
                sales.SetActive(true);
            }
            else
            {
                string loadusers = PlayerPrefs.GetString("userid");
                userid = loadusers;
                nameprice = "School";
                price = 400;
                StartCoroutine(BuyProduct());
                summ-=400;
                PlayerPrefs.SetInt("summ", summ);
                School_bild = 2;
                PlayerPrefs.SetInt("School_bild", School_bild);
                PlayerPrefs.Save();
                Button_School_bild_1.SetActive(false);
                Button_School_bild_2.SetActive(true);
                School_bild_prefab.SetActive(true);
                DateTime start_School = DateTime.Now;

                if (PlayerPrefs.HasKey("start_School"))
                    start_School = DateTime.Parse(PlayerPrefs.GetString("start_School"));
                else
                    PlayerPrefs.SetString("start_School", start_School.ToString());
                StartCoroutine(timer_School(start_School));
            }
        }
        else
        {
            panelBox.SetActive(true);
        }
            //int loadsum = PlayerPrefs.GetInt("summ");
            //summ = loadsum;
            //textSum.text = summ.ToString();
            int School_load = PlayerPrefs.GetInt("School_bild");
            School_bild = School_load;
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
    IEnumerator timer_School(DateTime start_School)
    {
        DateTime end = start_School.AddMinutes(60);
        while (DateTime.Now < end)
        {
            TimeSpan remaining = end - DateTime.Now;
            if (remaining.TotalSeconds > 1)
            {
                countdown_School.text = remaining.ToString("''m' : 's''");
                Debug.Log(remaining + " - countdown_School");   
            }
            yield return new WaitForSeconds(1f); 
        }
        School_bild_prefab.SetActive(false);
        School_buy = 2;
        PlayerPrefs.SetInt("School_buy", School_buy);
        PlayerPrefs.Save();
        Timer_School.SetActive(false);
        School_prefab.SetActive(true); 
    }


}