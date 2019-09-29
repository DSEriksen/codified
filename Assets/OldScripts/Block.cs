using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
    private bool clicked = false;

	void Update () {
        if (clicked) {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        transform.position = new Vector3(transform.position.x, transform.position.y, -1);
	}

    private void OnMouseDown()
    {
        clicked = true;
    }

    private void OnMouseUp()
    {
        clicked = false;
    }
}
