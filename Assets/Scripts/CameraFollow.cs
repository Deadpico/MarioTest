using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    
    public GameObject target;

    private Transform _t;
    private float yAxis = 0.6f;


	// Use this for initialization
	void Start () {
        _t = target.transform;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(_t.position.x, transform.position.y, transform.position.z);

	
	}
/*
    public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    public Transform target;

    void Update()
    {
        if (target)
        {
            Vector3 point = camera.WorldToViewportPoint(target.position);
            Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.3f, point.z));
            Vector3 destination = transform.position + delta;
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }

    }
 * */
}
