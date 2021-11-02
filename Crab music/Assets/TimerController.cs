using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimerController : MonoBehaviour
{
    public Text timerText;

    public float totalTime;
    public static int seconds;

    // Use this for initialization
    public static int getseconds()
    {
        return seconds;
    }

    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;
        seconds = (int)totalTime;
        timerText.text = seconds.ToString();
        if(seconds == 0)
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}