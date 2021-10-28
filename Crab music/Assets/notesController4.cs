using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notesController4 : MonoBehaviour
{
    GameObject crab;
    void Fallnote()
    {
        transform.Translate(0, -0.1f, 0);

        if (transform.position.y < -5.0f)
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
                Destroy(gameObject);
                GameObject.Find("Canvas").GetComponent<UIController>().AddScore();
            }
        }
    }

    void Start()
    {
        this.crab = GameObject.Find("Crab");
    }

    void Update()
    {
        Invoke("Fallnote", 1.5f);
    }

}
