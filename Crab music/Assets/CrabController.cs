using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabController : MonoBehaviour
{
    GameObject scoreText;
    Animator animator;

    void Start()
    {
        this.animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.animator.SetTrigger("Cut Trigger");
        }
    
    }


   
}
