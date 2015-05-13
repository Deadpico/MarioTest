using UnityEngine;
using System.Collections;

public class SmallCoin : MonoBehaviour {
    public float jumpSpeed = 0.1f;

    public Transform sightStart, sightEnd;
    public bool needCollision = true;
    public float speed = .5f;
    private bool collision = false;

    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        

        //rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
      //  rb.velocity = new Vector2(0,1);

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, transform.localScale.y) * speed;

        collision = Physics2D.Linecast(sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer("Solid"));
        Debug.DrawLine(sightStart.position, sightEnd.position, Color.green);

        if (collision == needCollision)
        {
            this.transform.localScale = new Vector3((transform.localScale.y == 1) ? -1 : 1, 1, 1);
        }
        
	}

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "CoinBox")
        {
            //rb.velocity = new Vector2(transform.localScale.x,0) * speed;
            Destroy(gameObject);
        }
    }

    public void CoinGoDown()
    {
        rb.velocity = new Vector2(1, 0);
    }
}
