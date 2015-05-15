﻿using UnityEngine;
using System.Collections;

public class PlayerDead : MonoBehaviour
{

    public LevelManager levelMananger;
    public Player playerClass;
    public AudioSource dyingInAgony;
    public AudioSource mainTheme;

    // Use this for initialization
    void Start()
    {
        levelMananger = FindObjectOfType<LevelManager>();
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
