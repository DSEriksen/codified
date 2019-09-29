using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Argument : MonoBehaviour {
    /*private bool clicked = false, inSocket = false;
    private GameObject socket;
    public int value;

    void Update()
    {
        if (clicked)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        transform.position = new Vector3(transform.position.x, transform.position.y, -2);
    }

    private void OnMouseDown()
    {
        clicked = true;

        if (!inSocket)
        {
            Instantiate(gameObject, transform.position, transform.rotation);
        }

        inSocket = false;

    }

    private void OnMouseUp()
    {
        clicked = false;
        if (inSocket) {
            transform.position = socket.transform.position;
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>().addParameter(value);
        } else {
            Destroy(gameObject);
            Debug.Log("destroyed");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Parameter" && clicked && collision.gameObject.GetComponentInParent<Command>().isActive())
        {
            socket = collision.gameObject;
            inSocket = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Parameter" && clicked)
        {
            socket = null;
            inSocket = false;
        }
    }*/
}
