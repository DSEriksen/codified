using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgScript : MonoBehaviour {
    public GameObject fadesprite;

    private void Start()
    {
        fadesprite.GetComponent<SpriteRenderer>().enabled = false;
    }
        
    public void fade() {
        fadesprite.GetComponent<SpriteRenderer>().enabled = true;
    }
}
