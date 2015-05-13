using UnityEngine;
using System.Collections;

public class BoxTrigger : MonoBehaviour {

    public QuestionBlock block;
    public GameObject coinPrefab;
    private SmallCoin Coin;

    private float coinX = -0.722f;
    private float coinY = 0.55f;
    private float jumpSpeed = 0.3f;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Player")
        {
            block.ChangeBox();
            Instantiate(coinPrefab, new Vector2(coinX, coinY), transform.rotation);
        }
        /*
        if (target.gameObject.tag == "Coin")
        {
            Coin.CoinGoDown();
        }
         */
    }
}
