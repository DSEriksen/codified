using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : ParentClass
{
    private float distanceMoved, speed = 2f, distanceCalculateSpeed = 2f;

	void Update () {
        distanceMoved += distanceCalculateSpeed*Time.deltaTime;
        transform.position += new Vector3(speed*Time.deltaTime, 0, 0);

        if (distanceMoved > parameter) { 
            Destroy(this);
        }
	}

    public override void setParameter(int i) {
        parameter = i;
        if (i < 0) {
            parameter *= -1;
            speed *= -1;
        }
    }
}
