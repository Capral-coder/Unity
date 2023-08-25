using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class Purchaser : MonoBehaviour
{
    public void OnPurchaseCompleted(Product product)
    {
        switch(product.definition.id)
        {

            case "com.speedsnailproduction.money100":
                Add100Money();
                break;
            case "com.speedsnailproduction.money1000":
                Add1000Money();
                break;
            case "com.speedsnailproduction.briliant100":
                Add100Briliant();
                break;
            case "com.speedsnailproduction.briliant500":
                Add500Briliant();
                break;
        }
    }


    private void Add100Money()
    {
        int summ = PlayerPrefs.GetInt("summ");
        summ += 100;
        PlayerPrefs.SetInt("summ", summ);
        Debug.Log("Purchase: get 100 coins");
    }
    private void Add1000Money()
    {
        int summ = PlayerPrefs.GetInt("summ");
        summ += 1000;
        PlayerPrefs.SetInt("summ", summ);
        Debug.Log("Purchase: get 1000 coins");
    }
    private void Add100Briliant()
    {
        int briliant = PlayerPrefs.GetInt("briliant");
        briliant += 100;
        PlayerPrefs.SetInt("briliant", briliant);
        Debug.Log("Purchase: get 100 briliant");
    }
    private void Add500Briliant()
    {
        int briliant = PlayerPrefs.GetInt("briliant");
        briliant += 500;
        PlayerPrefs.SetInt("briliant", briliant);
        Debug.Log("Purchase: get 500 briliant");
    }
}