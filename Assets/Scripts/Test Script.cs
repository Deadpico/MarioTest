using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

    private float delta = 0.25f;
    private float f = 0.2f;
    private float uLimit = 1.0f;
    private float lLimit = 0.0f;
    // Use this for initialization
    void Start()
    {
        Vector3 v = transform.localPosition;
        uLimit = v.y + f;
        lLimit = v.y - f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = transform.localPosition;
        v.y += delta * Time.deltaTime;
        Debug.Log(v.y);
        Debug.Log(delta);
        if (v.y >= uLimit)
        {
            delta = -0.25f;
        }
        else if (v.y < lLimit)
        {
            delta = 0.25f;
        }
        transform.localPosition = v;
	}
}
