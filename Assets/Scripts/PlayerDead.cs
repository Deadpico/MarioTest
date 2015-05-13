using UnityEngine;
using System.Collections;

public class PlayerDead : MonoBehaviour {

    public LevelManager levelMananger;

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
            levelMananger.RespawnPlayer();
            //OnDie();
        }
    }

    void OnDie()
    {
        levelMananger.RespawnPlayer();
    }
}
