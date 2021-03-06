﻿using UnityEngine;
using System.Collections;

public class PlayerDead : MonoBehaviour
{

    public LevelManager levelMananger;
    public Player playerClass;
    public AudioSource dyingInAgony;
    public AudioSource mainTheme;
    //public GameObject timeIsOut;

    private float currentTime;

    // Use this for initialization
    void Start()
    {
        levelMananger = FindObjectOfType<LevelManager>();
    }

    void Update()
    {
        //Timer.timeLeft = currentTime;
        //checkTimer(currentTime);
    }


    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Pit")
        {
            onDie();
        }

        if (target.gameObject.tag == "Deadly")
        {
            if (playerClass.marioHealth == 2)
            {
                playerClass.marioHealth--;
                playerClass.MarioGrow();
            }
            else
            {
                onDie();
              

            }
        }

        
       

        
    }

    //void checkTimer(float currentTime)
    //{
    //    if (currentTime < 0)
    //    {
    //        onDie();
    //    }
    //}

    void onDie()
    {
        mainTheme.Pause();
        dyingInAgony.Play();
        GetComponent<Player>().enabled = false;
        GetComponent<PlayerController>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;
        StartCoroutine(LoadLevel(1));
    }

    IEnumerator LoadLevel(int delay)
    {
        yield return new WaitForSeconds(4);
        Application.LoadLevel(1);
    }

}
