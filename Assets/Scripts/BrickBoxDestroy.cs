using UnityEngine;
using System.Collections;

public class BrickBoxDestroy : MonoBehaviour {

    public GameObject block;

    private Player playerClass;

    // Use this for initialization
    void Start()
    {
        playerClass = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Player")
            if(playerClass.marioHealth == 2)
             {
                Destroy(block);
            }

    }
}