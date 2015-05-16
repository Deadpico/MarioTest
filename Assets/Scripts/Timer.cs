using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {
    public static float timeLeft;
    private Text timeUI;
    private int seconds;
    private int minutes;

	// Use this for initialization
	void Start () {
        timeLeft = 5f;
        timeUI = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        seconds = (int)timeLeft % 60;
        minutes = (int)timeLeft / 60;

        if (timeLeft < 0)
        {
            timeLeft = 0;
        }

        timeUI.text = minutes + ":" + seconds;

        


	
	}

    

   
}
