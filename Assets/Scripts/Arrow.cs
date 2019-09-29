using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {
    public int i;

    private void OnMouseDown()
    {
        if (GetComponentInParent<Kommando>().isActive() && !PlayerScript.isPlaying)
            GetComponentInParent<Kommando>().changeArg(i);
    }
}
