using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class hospital_buy : MonoBehaviour
{   
    private int Hospital_buy;
    private int Hospital_bild;

    private DateTime start_Hospital = DateTime.Now;
    private float time = 60;
    private string nameprice;
    private int price;
    private string userid;
    private string loadusers;
    
    public string nameBuy;
    public int summ;
    public Text textSum;
    public TextMesh countdown_Hospital;
    public GameObject Timer_Hospital;

    [SerializeField]
    GameObject Hospital_prefab, Hospital_bild_prefab;

    [SerializeField]
    GameObject Button_Hospital_bild_1, Button_Hospital_bild_2;

    [SerializeField]
    public GameObject panelBox, sales;

    public GameObject spawn_ambulense_car;

    void Start()
    {
        //summ;
        int summ = PlayerPrefs.GetInt("summ");
        textSum.text = summ.ToString();

        int Hospital_bild = PlayerPrefs.GetInt("Hospital_bild");
        if (Hospital_bild == 2)
        {
            Button_Hospital_bild_1.SetActive(false);
            Button_Hospital_bild_2.SetActive(true); 
            Hospital_bild_prefab.SetActive(true);
            if (PlayerPrefs.HasKey("start_Hospital"))
                start_Hospital = DateTime.Parse(PlayerPrefs.GetString("start_Hospital"));
            else
                PlayerPrefs.SetString("start_Hospital", start_Hospital.ToString());
            StartCoroutine(timer_Hospital(start_Hospital));

        }
        
        int Hospital_buy = PlayerPrefs.GetInt("Hospital_buy");
        if (Hospital_buy == 2)
        {
            Hospital_bild = 3;
            PlayerPrefs.SetInt("Hospital_bild", Hospital_bild);
            Hospital_bild_prefab.SetActive(false);
            Hospital_prefab.SetActive(true);
            Button_Hospital_bild_1.SetActive(false);
            Button_Hospital_bild_2.SetActive(true);
        }
    }
    void Update()
    {

        int loadsum = PlayerPrefs.GetInt("summ");
        summ = loadsum;
        textSum.text = summ.ToString();

        int Hospital_load = PlayerPrefs.GetInt("Hospital_bild");
        Hospital_bild = Hospital_load;
        if(Hospital_bild == 2)
        { 
            Debug.Log("Строиться");
        }

        int Hospital_buy_load = PlayerPrefs.GetInt("Hospital_buy");
        Hospital_buy = Hospital_buy_load;
        if(Hospital_buy == 2)
        { 
            spawn_ambulense_car.SetActive(true);
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
    
    public void BuyStoreHospital()
    {
        nameBuy = "Hospital";
        BuyStore();
    }
    public void BuyStore()
    {

        if (nameBuy == "Hospital" && summ >= 500)
        {
            if (Hospital_bild == 2 || Hospital_bild == 3) 
            {
                sales.SetActive(true);
            }
            else
            {
                string loadusers = PlayerPrefs.GetString("userid");
                userid = loadusers;
                nameprice = "Hospital";
                price = 500;
                StartCoroutine(BuyProduct());
                summ-=500;
                PlayerPrefs.SetInt("summ", summ);
                Hospital_bild = 2;
                PlayerPrefs.SetInt("Hospital_bild", Hospital_bild);
                PlayerPrefs.Save();
                Button_Hospital_bild_1.SetActive(false);
                Button_Hospital_bild_2.SetActive(true);
                Hospital_bild_prefab.SetActive(true);
                DateTime start_Hospital = DateTime.Now;

                if (PlayerPrefs.HasKey("start_Hospital"))
                    start_Hospital = DateTime.Parse(PlayerPrefs.GetString("start_Hospital"));
                else
                    PlayerPrefs.SetString("start_Hospital", start_Hospital.ToString());
                StartCoroutine(timer_Hospital(start_Hospital));
            }
        }
        else
        {
            panelBox.SetActive(true);
        }
            //int loadsum = PlayerPrefs.GetInt("summ");
            //summ = loadsum;
            //textSum.text = summ.ToString();
            int Hospital_load = PlayerPrefs.GetInt("Hospital_bild");
            Hospital_bild = Hospital_load;
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
    IEnumerator timer_Hospital(DateTime start_Hospital)
    {
        DateTime end = start_Hospital.AddMinutes(30);
        while (DateTime.Now < end)
        {
            TimeSpan remaining = end - DateTime.Now;
            if (remaining.TotalSeconds > 1)
            {
                countdown_Hospital.text = remaining.ToString("''m' : 's''");
                Debug.Log(remaining + " - countdown_Hospital");   
            }
            yield return new WaitForSeconds(1f); 
        }
        Hospital_bild_prefab.SetActive(false);
        Hospital_buy = 2;
        PlayerPrefs.SetInt("Hospital_buy", Hospital_buy);
        PlayerPrefs.Save();
        Timer_Hospital.SetActive(false);
        Hospital_prefab.SetActive(true); 
    }


}