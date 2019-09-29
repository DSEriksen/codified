using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentClass : MonoBehaviour {
    protected int parameter;

	public virtual void setParameter(int i) {
        parameter = i;
        Debug.Log("Base method");
    }
}
