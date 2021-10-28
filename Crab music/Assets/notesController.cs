using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notesController : MonoBehaviour
{
    GameObject crab;
    AudioSource sound01;

    void Start()
    {
        this.crab = GameObject.Find("Crab");
        sound01 = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        transform.Translate(0,-0.05f,0);

        if(transform.position.y < -7f)
        {
            Destroy(gameObject);
        }


        Vector2 p1 = transform.position;
        Vector2 p2 = this.crab.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if (d < r1 + r2)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {

                sound01.PlayOneShot(sound01.clip); 
            }
        }
    }
}
