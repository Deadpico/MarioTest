using UnityEngine;
using System.Collections;

public class GoombaDeath : MonoBehaviour {

    private Animator anim;

    

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void goombaAnimDeath()
    {
        anim.SetInteger("AnimState", 1);
    }



}
