using UnityEngine;
using System.Collections;

public class MushroomScript : MonoBehaviour {
    public Transform sightStart, sightEnd;
    public bool needCollision = true;
    public float speed = .5f;
    private Player playerClass;

    private bool collision = false;
    

	// Use this for initialization
	void Start () {
        playerClass = FindObjectOfType<Player>();
	}
	
	// Update is called once per frame
	void Update () {
	GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x, 0) * speed;

        collision = Physics2D.Linecast(sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer("Solid"));
        Debug.DrawLine(sightStart.position, sightEnd.position, Color.green);

        if (collision == needCollision)
        {
            this.transform.localScale = new Vector3((transform.localScale.x == 1) ? -1 : 1, 1, 1);
        }
	}

    void OnCollisionEnter2D(Collision2D colli)
    {
        if (colli.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            playerClass.marioHealth++;
            playerClass.MarioGrow();
        }

    }

}
