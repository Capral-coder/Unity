using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;

public class UserID : MonoBehaviour
{   
    private string userid;
    private int camera;
    private int tutorial;
    public  InputField inputField;
    
    public GameObject Userid_panel;

    public Text textSum;

    void Start()
    {
        string userid = PlayerPrefs.GetString("userid");
        if (Regex.IsMatch(userid, @"\S"))
        {
            Userid_panel.SetActive(false);
        }
        else
        {
            Userid_panel.SetActive(true);
        }
    }
    public void Tests()
    {
        userid = inputField.text;
        if (Regex.IsMatch(userid, @"\S"))
        {
            int summ = PlayerPrefs.GetInt("summ");
            int briliant = PlayerPrefs.GetInt("briliant");
            summ+=1000;
            PlayerPrefs.SetInt("summ", summ);
            briliant+=25;
            PlayerPrefs.SetInt("briliant", briliant);
            tutorial = 2;
            PlayerPrefs.SetInt("tutorial", tutorial);
            StartCoroutine(userid_save());
            PlayerPrefs.SetString("userid", userid);
            camera = 2;
            PlayerPrefs.SetInt("camera", camera);
            PlayerPrefs.Save();
            Userid_panel.SetActive(false);
            textSum.text = summ.ToString();
        }
        
    }

    public IEnumerator userid_save()
    {
        WWWForm form = new WWWForm();
        form.AddField("Userid", userid);
        WWW www = new WWW("https://cities-game.ml/userid_save.php", form);
        yield return www;
        if (www.error != null)
        {
            Debug.Log("Помилка" + www.error);
            yield break;
        }
        Debug.Log("Все ок" + www.text);
    }

    public  IEnumerator userid_load()
    {
        WWWForm form = new WWWForm();
        form.AddField("Userid", userid);
        WWW www = new WWW("https://cities-game.ml/userid_load.php", form);
        yield return www;
        if (www.error != null)
        {
            Debug.Log("Помилка" + www.error);
            yield break;
        }
        Debug.Log("Все ок" + www.text);


    }


}
