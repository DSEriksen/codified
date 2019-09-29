using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command : MonoBehaviour {
    /*private bool clicked = false, inSocket = false;
    private Vector3 socketPos;
    public int scriptID;
    private GameObject socket;

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
        clicked = true;

        if (!inSocket) {
            Instantiate(gameObject, transform.position, transform.rotation);
        }

        inSocket = false;

    }

    private void OnMouseUp()
    {
        clicked = false;
        if (inSocket) {
            socketPos.z = -1;
            transform.position = socketPos;
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>().addCommand(scriptID);
            socket.GetComponent<Socket>().createNew();
        } else {
            Destroy(gameObject);
            Debug.Log("destroyed command");
        }

        Debug.Log(inSocket);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ActiveSocket" && clicked) {
            socketPos = collision.gameObject.transform.position;
            inSocket = true;
            socket = collision.gameObject;
            Debug.Log("set to true");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ActiveSocket" && clicked) {
            socketPos = Vector3.zero;
            inSocket = false;
            Debug.Log("set to false");
        }
    }


    public bool isActive()
    {
        if (inSocket)
            return true;
        else
            return false;
    }*/
}
