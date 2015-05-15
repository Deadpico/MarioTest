using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{

    public GameObject target;

    private Transform _t;
    private float yAxis = 0.6f;


    // Use this for initialization
    void Start()
    {
        _t = target.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(_t.position.x, transform.position.y, transform.position.z);


    }

}
