using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeScreenPlay : MonoBehaviour {
    public static string username;

	// Use this for initialization
	void Start () {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(play);
    }
	
	private void play() {
        username = GameObject.Find("navn").GetComponent<InputField>().text;
        SceneManager.LoadScene("Prog1");
    }
}
