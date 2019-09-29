using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour {
    public GameObject screen;
    public static double start, finish, first;

    // Use this for initialization
    void Start () {
        screen = GameObject.Find("screen");
        screen.SetActive(false);
        DataLogger.updateSceneName();
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(3f, 0f, 0f));
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            screen.SetActive(true);
            Time.timeScale = 0;
            GameObject.Find("bgFaded").GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject);
            DataLogger.setClicks();
            finish = Time.time;
            DataLogger.addData(start, finish, first);
            PlayerScript.isPlaying = false;
        }
    }
}
