using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionButton : MonoBehaviour {
    public int actionID;

    void Start()
    {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(addAction);
    }

    void addAction()
    {
        //GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>().addAction(actionID);
    }
}
