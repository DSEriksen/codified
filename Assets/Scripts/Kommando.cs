using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kommando : MonoBehaviour {
    private bool clicked = false, inSocket = false;
    private Vector3 socketPos;
    public int scriptID;
    private int arg = 0, index;
    private GameObject socket;
    private GameObject player;
    public Sprite active;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        clicked = false; inSocket = false;
    }

    void Update()
    {
        if (clicked)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(transform.position.x, transform.position.y, -3);
        }
    }

    private void OnMouseDown()
    {
        if (!inSocket && !PlayerScript.isPlaying)
        {
            Instantiate(gameObject, transform.position, transform.rotation);
            GetComponent<SpriteRenderer>().sprite = active;
            clicked = true;
            Debug.Log("HEJ");
            GameObject.FindGameObjectWithTag("ActiveSocket").GetComponent<Socket>().setActiveSprite();
        }
    }

    private void OnMouseUp()
    {
        if (inSocket && clicked && !PlayerScript.isPlaying)
        {
            socketPos.z = -1;
            transform.position = socketPos;
            index = player.GetComponent<PlayerScript>().addCommand(scriptID, arg);
            Debug.Log(index + " created");
            GetComponentInChildren<TextMesh>().text = "";
            socket.GetComponent<Socket>().createNew();
        }
        else if (clicked && !PlayerScript.isPlaying)
        {
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("ActiveSocket").GetComponent<Socket>().setDefaultSprite();
        }
        clicked = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ActiveSocket" && clicked)
        {
            socketPos = collision.gameObject.transform.position;
            inSocket = true;
            Debug.Log(inSocket);
            socket = collision.gameObject;
        }

        Debug.Log(inSocket);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ActiveSocket" && clicked)
        {
            socketPos = Vector3.zero;
            inSocket = false;
        }
        Debug.Log(inSocket);
    }

    public void changeArg(int i) {
        switch(scriptID) { 
        case 0:
            arg += i;
            player.GetComponent<PlayerScript>().changeParameter(index, arg);
            GetComponentInChildren<TextMesh>().text = arg.ToString();
            break;
        case 2:
            arg += i;

            if (arg > 1)
                arg = 1;
            else if (arg < -1)
                arg = -1;
            
            switch (arg) { 
            case -1:
                GetComponentInChildren<TextMesh>().text = "Tilbage";
                break;
            case 0:
                GetComponentInChildren<TextMesh>().text = "";
                break;
            case 1:
                GetComponentInChildren<TextMesh>().text = "Frem";
                break;
            }
            player.GetComponent<PlayerScript>().changeParameter(index, arg);
            break;
        }
            

    }

    public bool isActive()
    {
        if (inSocket)
            return true;
        else
            return false;
    }
}
