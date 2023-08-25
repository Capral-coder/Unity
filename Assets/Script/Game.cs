using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Mono.Data.Sqlite;
using Mono.Data;
using System.Data;
using System.IO;

public class Game : MonoBehaviour
{

    List<string> used_cities = new List<string>();
    List<string> query_SQL = new List<string>();
    System.Random random = new System.Random();
    char last_charter = ' ';
    public SqliteConnection DB;
    private string DBpath;
    private string conn;
    private int Game_point;

    private string enterCity;
    private string user_city;

    public InputField inputField;
    public Text enterText;
    public int summ;
    public Text textSum;
    public int briliant;
    public Text textBriliant;
    public GameObject error;
    public Text textError;
    public Button Button_Game, Button_Exit;

    // Start is called before the first frame update
    void Start()
    {
        enterText.text = "Введіть місто";
    }

    void Update()
    {
        int loadsum = PlayerPrefs.GetInt("summ");
        summ = loadsum;
        textSum.text = summ.ToString();

        int loadbriliant = PlayerPrefs.GetInt("briliant");
        briliant = loadbriliant;
        textBriliant.text = briliant.ToString();
    }

    public void ErrorClose()
    {
        error.SetActive(false);
        inputField.interactable = true;
        Button_Game.interactable = true;
        Button_Exit.interactable = true;

    }

    public void City()
    {
        WWW loadDB = new WWW("jar:file://" + Application.dataPath + "!/assets/example.db");
        while (!loadDB.isDone) { }
        // then save to Application.persistentDataPath
        string filepath = Application.persistentDataPath + "/example.db";
        File.WriteAllBytes(filepath, loadDB.bytes);  
        conn = "URI=file:" + filepath;
        //enterText.text = "Stablishing connection to: " + conn;
        ///DBpath =  "jar:file://" + Application.dataPath + "!/assets";
        /////////////////DBpath =  Application.dataPath + "/StreamingAssets/example.bytes";
        /////////////////DB = new SqliteConnection("URI=file:" + DBpath);
        DB = new SqliteConnection(conn);
        DB.Open();
        string city = inputField.text.Trim();
        string query = "";
        if (used_cities.Count >= 1){
            used_cities.ForEach(i => query += ("'" + i + "',"));
            query = query.Remove(query.Length-1);
        }
        SqliteCommand CMD = new SqliteCommand($"SELECT * FROM cities WHERE name = '{city}' AND name NOT IN ({query})", DB);
        SqliteDataReader data = CMD.ExecuteReader();
        if((last_charter == ' ' || last_charter == city[0]) && data.Read()){
            if('Ь'.Equals(city.ToUpper()[city.Length - 1]) || 'И'.Equals(city.ToUpper()[city.Length - 1])){
                  last_charter = city.ToUpper()[city.Length - 2];
            } else {
                  last_charter = city.ToUpper()[city.Length - 1];
            };
            used_cities.Add(city);
            query = "";
            used_cities.ForEach(i => query += ("'" + i + "',"));
            query = query.Remove(query.Length-1);
            CMD = new SqliteCommand($"SELECT * FROM cities WHERE name NOT IN ({query}) AND name LIKE '{last_charter}%'", DB);
            data = CMD.ExecuteReader();
            int get_max = 0;
            bool bot_lose = false;
            while (data.Read()){
                bot_lose = true;
                if (get_max <= 100){
                    query_SQL.Add(data["name"].ToString());
                    get_max += 1;
                } else {
                    break;
                };
            }
            if (!bot_lose){
                enterText.text = "Перемога!";
                briliant+=1000;
                PlayerPrefs.SetInt("briliant", briliant);
                PlayerPrefs.Save();
            }
            int num = random.Next(1, query_SQL.Count+1); 
            summ+=2;
            PlayerPrefs.SetInt("summ", summ);
            Game_point+=1;
            PlayerPrefs.SetInt("Game_point", Game_point);
            PlayerPrefs.Save();  
            enterText.text = (query_SQL[num-1]);
            used_cities.Add(query_SQL[num-1]);
            if('Ь'.Equals(query_SQL[num-1].ToUpper()[query_SQL[num-1].Length - 1]) || 'И'.Equals(query_SQL[num-1].ToUpper()[query_SQL[num-1].Length - 1])){
                  last_charter = query_SQL[num-1].ToUpper()[query_SQL[num-1].Length - 2];
            } else {
                  last_charter = query_SQL[num-1].ToUpper()[query_SQL[num-1].Length - 1];
            };
            query_SQL.Clear();
        } else {
            if (used_cities.Contains(city)){
                error.SetActive(true);
                inputField.interactable = false;
                Button_Game.interactable = false;
                Button_Exit.interactable = false;
                textError.text = "Ви вже ввели це місто";
            } else if (!data.Read()) {
                error.SetActive(true);
                inputField.interactable = false;
                Button_Game.interactable = false;
                Button_Exit.interactable = false;
                textError.text = "Я не знаю такого міста";
            } else if (last_charter != city[0]){
                error.SetActive(true);
                inputField.interactable = false;
                Button_Game.interactable = false;
                Button_Exit.interactable = false;
                textError.text = $"Ваше місто починається на букву ({last_charter})";     
            }
        }
    }
}