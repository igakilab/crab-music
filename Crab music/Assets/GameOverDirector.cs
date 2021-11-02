using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOverDirector : MonoBehaviour
{
    public float totalTime;
    public static int seconds;


    // Update is called once per frame
    void Update()
    {
        totalTime += Time.deltaTime;
        seconds = (int)totalTime;
        if (seconds == 63)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
