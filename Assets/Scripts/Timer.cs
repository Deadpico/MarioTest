﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {
    public float timeLeft;
    private Text timeUI;
    private int seconds;
    private int minutes;

	// Use this for initialization
	void Start () {
        timeUI = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        seconds = (int)timeLeft % 60;
        minutes = (int)timeLeft / 60;
        //timeUI.text = minutes + ":" + seconds;
        timeUI.text = minutes + ":" + seconds; 
       //GetComponent<GUIText>().text = minutes + ":" + seconds;


	
	}

   
}
