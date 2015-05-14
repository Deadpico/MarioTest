using UnityEngine;
using System.Collections;

public class ExitLevel : MonoBehaviour {

    public string scene;
    public AudioSource winGame;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Player")
        {
            winGame.Play();
            Destroy(target.gameObject);
            StartCoroutine(LoadLevel(scene));
            
        }
    }

    IEnumerator LoadLevel(string scene)
    {
        yield return new WaitForSeconds(7);
        Application.LoadLevel(scene);
    }
}
