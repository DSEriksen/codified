using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataLogger : MonoBehaviour {

    public static DataLogger logger;
    public static int play1, play2, play3, playClicks, totalclicks;
    public static double prog1start, prog1finish, prog1first, prog2start, prog2finish, prog2first, prog3start, prog3finish, prog3first;
    private static string scene = "";
 
    void Start()
    {
        updateSceneName();
        if (logger == null)
        {
            logger = gameObject.GetComponent<DataLogger>();
        }
        else
        {
            DestroyObject(gameObject);
        }
        
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            totalclicks++;
        }
    }

    private void OnApplicationQuit()    
    {
        string[] lines =    {
                            "Prog1:", "time: " + (prog1finish - prog1start), "first: " + prog1first, "playclicks: " + play1, "",
                            "Prog2:", "time: " + (prog2finish - prog2start), "first: " + prog2first, "playclicks: " + play2, "",
                            "Prog3:", "time: " + (prog3finish - prog3start), "first: " + prog3first, "playclicks: " + play3, "",
                            "total clicks: " + totalclicks
                            };

        string docName = "\\" + HomeScreenPlay.username + "_" + Random.Range(0, 100000000).ToString() + ".txt";
        string mydocpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);

        using (System.IO.StreamWriter outputFile = new System.IO.StreamWriter(mydocpath + @docName))
        {
            Debug.Log(mydocpath);

            foreach (string line in lines)
                outputFile.WriteLine(line);
        }
    }

    public static void setClicks() {
        switch (scene)
        {
            case "Prog1":
                play1 = playClicks;
                break;
            case "Prog2":
                play2 = playClicks;
                break;
            case "Prog3":
                play3 = playClicks;
                break;
        }
        playClicks = 0;
    }

    public static void addData(double start, double finish, double first) {
        switch(scene) {
            case "Prog1":
                prog1start = start;
                prog1finish = finish;
                prog1first = first;
                break;
            case "Prog2":
                prog2start = start;
                prog2finish = finish;
                prog2first = first;
                break;
            case "Prog3":
                prog3start = start;
                prog3finish = finish;
                prog3first = first;
                break;
        }
    }

    public static void updateSceneName() {
        string newscene = SceneManager.GetActiveScene().name;
        if (!scene.Equals(newscene)) { 
            Coin.start = Time.time;
            FirstClickListener.clicked = false;
        }

        scene = newscene;
    }
}
