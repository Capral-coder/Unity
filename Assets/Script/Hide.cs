using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    public void hideIt(GameObject obj) {
        obj.SetActive(false);
    }
}
