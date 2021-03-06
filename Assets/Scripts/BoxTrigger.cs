﻿using UnityEngine;
using System.Collections;

public class BoxTrigger : MonoBehaviour
{

    public QuestionBlock block;
    public GameObject Prefab;
    public int numberOfCoins;
    public GameObject target;




    private Transform _t;
    private int numberOfHits;
    private SmallCoin Coin;
    private float coinX = -0.722f;
    private float coinY = 0.55f;
    private float jumpSpeed = 0.3f;
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _t = target.transform;


    }



    void OnTriggerEnter2D(Collider2D target)
    {

        if (target.gameObject.tag == "Player")
        {
            numberOfHits++;

            if (numberOfHits <= numberOfCoins)
            {
                Instantiate(Prefab, new Vector2(_t.position.x, _t.position.y + 0.2f), transform.rotation);
                gameObject.tag = "CoinBoxDead";
                GetComponent<AudioSource>().Play();
            }
            if (numberOfHits == numberOfCoins)
            {
                block.ChangeBox();
            }
        }


    }

}

