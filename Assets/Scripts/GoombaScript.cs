using UnityEngine;
using System.Collections;

public class GoombaScript : MonoBehaviour {

    public Transform sightStart, sightEnd;
    public bool needCollision = true;
    public float speed = .5f;
    public Transform weakness;

    private bool collision = false;
    Animator anim;


	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
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
            float height = colli.contacts[0].point.y - weakness.position.y;
            if(height>0){
                colli.rigidbody.AddForce(new Vector2(0, 100));
                dies();
            }
        }
        
    }

    void dies()
    {
        anim.SetBool("Stomped", true);
        gameObject.tag = "Nautralized";
        Destroy(this.gameObject, 0.5f);
        
    }
}
