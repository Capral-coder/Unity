using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Nimer : MonoBehaviour
{
    public Text countdown;

    void Start()
    {
        DateTime start = DateTime.Now;
    
        if (PlayerPrefs.HasKey("start"))
            start = DateTime.Parse(PlayerPrefs.GetString("start"));
        else
            PlayerPrefs.SetString("start", start.ToString());

        StartCoroutine(timer(start));
    }
    
    IEnumerator timer(DateTime start)
    {
        DateTime end = start.AddHours(5);
        while (DateTime.Now < end)
        {
            TimeSpan remaining = end - DateTime.Now;
            if (remaining.TotalSeconds > 1)
            {
                countdown.text = remaining.ToString("'До указанного времени осталось 'h' часов 'm' минут 's' секунд'");
                Debug.Log(remaining + " - Countdown");
            }
    
            yield return new WaitForSeconds(1f);
        }
    
        // Отсчет закончился — сбрасываем время начала.
        // Замените на метод, который отвечает за удаление значения.

        PlayerPrefs.DeleteKey("start");
    }
}
