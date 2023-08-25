using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efects : MonoBehaviour
{
    private int location;
    [SerializeField] private Behaviour efects_snow;

    // Update is called once per frame
    void Update()
    {
        int game_start = PlayerPrefs.GetInt("game_start");

        if (game_start == 2)
        {
            efects_snow.enabled = false;
        }
        else
        {
            efects_snow.enabled = true;
        }
    }
}
