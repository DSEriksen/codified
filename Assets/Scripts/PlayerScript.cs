using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    public List<int> commands = new List<int>();
    public List<int> parameters = new List<int>();
    private Component command;
    public static bool isPlaying = false;
    private int index;

    void Start () {
        command = gameObject.AddComponent<DoNothing>();
    }
	
	void Update () {
        if (command == null)
        {
            if (index < commands.Count)
            { 
                addNewScript(commands[index]);
            }
        }
    }

    public void addNewScript(int i) {
        switch (i)
        {
            case 0:
                command = gameObject.AddComponent<MoveRight>();
                command.GetComponent<MoveRight>().setParameter(parameters[index]);
                break;
            case 1:
                command = gameObject.AddComponent<Jump>();
                break;
            case 2:
                command = gameObject.AddComponent<JumpRight>();
                command.GetComponent<JumpRight>().setParameter(parameters[index]);
                break;
        }
        index++;
    }

    public int addCommand(int i, int j) {
        if (!isPlaying) { 
            commands.Add(i);
            parameters.Add(j);
            //Debug.Log(commands.Count);
        }
        // Debug.Log("Script ID: " + i + " added to player");
        int x = commands.Count - 1;
        return x;
    }

    public void changeParameter(int index, int value) {
        parameters[index] = value;
    }

    public void startGame() {
        isPlaying = true;
        Destroy(gameObject.GetComponent<DoNothing>());
        command = null;
       // Debug.Log("Your code is running!");
    }

    public void stop() {
        command = gameObject.AddComponent<DoNothing>();
        Destroy(command);
        index--;
        switch (commands[index])
        {
            case 0:
                Destroy(gameObject.GetComponent<MoveRight>());
                Debug.Log("DESTROYED MOVERIGHT");
                break;
            case 1:
                Destroy(gameObject.GetComponent<Jump>());
                break;
            case 2:
                Destroy(gameObject.GetComponent<JumpRight>());

                Debug.Log("DESTROYED JUMP");
                break;
        }
    }
}
