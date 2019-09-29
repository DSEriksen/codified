using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour {
    public string newScene;

    void Start()
    {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick() {
        SceneManager.LoadScene(newScene);
    }
}
