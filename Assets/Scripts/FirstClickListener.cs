using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstClickListener : MonoBehaviour {
    public static bool clicked = false;
    private void OnMouseDown()
    {
        if (!clicked) {
        Debug.Log("CLICLICLCILIC");
        Coin.first = Time.time - Coin.start;
        clicked = true;
        }
    }
}
