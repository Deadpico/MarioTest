using UnityEngine;
using System.Collections;

public class GoombaTrigger : MonoBehaviour {

    public GoombaDeath goombaAnim;
    public bool stomp = false;
    public GameObject goomba;
    public Transform weakness;

    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
       // StartCoroutine(KillOnAnimationEnd());
        //if (stomp )
            
            
    }

   /* private IEnumerator KillOnAnimationEnd()
    {
        if (!stomp)
        {
            yield return new WaitForSeconds(0.167f);
            Destroy(gameObject);
        }
        
    }
    */
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.name == "Player")
        {
            goombaAnim.goombaAnimDeath();
            stomp = true;
        }

    }


}
