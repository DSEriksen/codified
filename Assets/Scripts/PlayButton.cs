using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {
    public bool beenClicked = false;
    public Sprite stop, start;

	// Use this for initialization
	void Start () {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(play);
        beenClicked = false;

    }

    void play () {

        if (!beenClicked) { 
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>().startGame();
            gameObject.GetComponent<Image>().sprite = stop;
            GameObject.Find("BackGround").GetComponent<bgScript>().fade();
            DataLogger.playClicks++;
        } else {
            gameObject.GetComponent<Image>().sprite = start;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            PlayerScript.isPlaying = false;
        }
        beenClicked = !beenClicked;
    } 
}
