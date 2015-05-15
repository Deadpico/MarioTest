using UnityEngine;
using System.Collections;

public class QuestionBlock : MonoBehaviour
{

    private Animator anim;




    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }



    public void ChangeBox()
    {
        anim.SetInteger("AnimState", 1);
    }


}
