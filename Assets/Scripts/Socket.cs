using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket : MonoBehaviour {
    public Sprite defaultSprite, active;

    private void Start()
    {
        setDefaultSprite();
    }

    public void createNew() {
        if (gameObject.tag == "ActiveSocket") { 
        GameObject newSocket = Instantiate(gameObject, new Vector3(transform.position.x, transform.position.y - 0.583f, transform.position.z), transform.rotation);
        newSocket.tag = "ActiveSocket";
        gameObject.tag = "Socket";
        setDefaultSprite();
        }
    }

    public void setActiveSprite() {
        GetComponent<SpriteRenderer>().sprite = active;
    }

    public void setDefaultSprite() {
        GetComponent<SpriteRenderer>().sprite = defaultSprite;
    }
}
