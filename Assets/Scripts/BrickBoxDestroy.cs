using UnityEngine;
using System.Collections;

public class BrickBoxDestroy : MonoBehaviour {

    public GameObject block;
    public AudioSource[] sounds;
    public AudioSource marioBig;
    public AudioSource marioSmall;
    public SpriteRenderer noRend;
   
    private Player playerClass;

    // Use this for initialization
    void Start()
    {
        playerClass = FindObjectOfType<Player>();
        sounds = GetComponents<AudioSource>();
        marioSmall = sounds[0];
        marioBig = sounds[1];
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
                marioBig.Play();
                noRend = (SpriteRenderer)GetComponentInParent(typeof(SpriteRenderer));
                noRend.enabled = false;
                Destroy(block, 1f);
             }
            else if (playerClass.marioHealth == 1)
            {
                marioSmall.Play();
            }

    }
}