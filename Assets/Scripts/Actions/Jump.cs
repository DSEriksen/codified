using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : ParentClass
{

	void Start () {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 500, 0));
	}

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Ground")
            Destroy(this);
    }
}
