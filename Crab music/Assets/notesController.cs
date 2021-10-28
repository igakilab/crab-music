//‰¹•„‚Ì“®‚«
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notesController : MonoBehaviour
{
    GameObject crab;
    void Fallnote()
    {
        gameObject.SetActive(true);//gameObject‚Ì•\Ž¦
        transform.Translate(0, -0.1f, 0);

        if (transform.position.y < -5.0f)
        {
            gameObject.SetActive(false);
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
                gameObject.SetActive(false); //gameObject‚Ì”ñ•\Ž¦
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
        Invoke("Fallnote", 0.0f);
        Invoke("Fallnote", 6.0f);
    }

}
