using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldPlayerScript : MonoBehaviour {
    Component action; 
    List<int> actions = new List<int>();
    int index;
    private bool isPlaying = false, wonLevel = false;

    private void Start()
    {
        action = gameObject.AddComponent<DoNothing>();
    }

    void Update() {
        if (action == null) {
            if (index < actions.Count)
                addNewScript(actions[index]);
            else if (wonLevel)
            {
                Debug.Log("won");
            }
            else
                Debug.Log("lost");
        }

        if (Input.GetKeyDown(KeyCode.R))
            reset();
    }

    void addNewScript(int newIndex) {
        switch(newIndex) {
            case 0:
                action = gameObject.AddComponent<MoveRight>();
                break;
            case 1:
                action = gameObject.AddComponent<Jump>();
                break;
            case 2:
                action = gameObject.AddComponent<JumpRight>();
                break;
        }

        

        index++;
    }

    public void startGame()
    {
        action = null;
        isPlaying = true;
    }

    public void addAction(int i)
    {
        if (!isPlaying)
            actions.Add(i);
    }

    public void reset()
    {
        isPlaying = false;
        actions.Clear();
        transform.position = new Vector3(-8, -3, 0);
        index = 0;
        action = gameObject.AddComponent<DoNothing>();
        GameObject.Find("Play").GetComponent<PlayButton>().beenClicked = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Point") {
            wonLevel = true;
            Debug.Log(wonLevel);
        }
    }
}
