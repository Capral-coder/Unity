using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip clickFx;


    public void Click_Button()
    {
        myFx.PlayOneShot(clickFx);
    }
}
