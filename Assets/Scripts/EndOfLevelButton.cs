using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfLevelButton : MonoBehaviour {
    public Sprite clicked, unclicked;
    public string scene;
    

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = clicked;
        SceneManager.LoadScene(scene);
        Time.timeScale = 1;

    }

    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = unclicked;
    }
}
