using UnityEngine;
using System.Collections;

public class PlayerDead : MonoBehaviour {

    public LevelManager levelMananger;
    public Player playerClass;
    public AudioSource dyingInAgony;
    public AudioSource mainTheme;

	// Use this for initialization
	void Start () {
        levelMananger = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
/*
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.name == "Player")
        {
            OnDie();
        }
    }
 * */
    
    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Deadly")
        {
            if (playerClass.marioHealth == 2)
            {
                playerClass.marioHealth--;
                playerClass.MarioGrow();
            }
            else
            {
                // respawns palyer for bugtesting
                //levelMananger.RespawnPlayer();
                mainTheme.Pause();
                dyingInAgony.Play();


                StartCoroutine(LoadLevel(1));
            }
        }
    }

    IEnumerator LoadLevel(int delay)
    {
        yield return new WaitForSeconds(4);
        Application.LoadLevel(1);
    }

}
