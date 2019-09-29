using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpRight : ParentClass
{

    private float speed = 2f;

    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 300, 0));
    }

    private void Update()
    {
        float newX = transform.position.x;
        newX += speed * Time.deltaTime;
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
        Debug.Log(parameter);
    }

    public override void setParameter(int i)
    {
        parameter = i;
        speed *= parameter;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            Destroy(this);
    }
}
