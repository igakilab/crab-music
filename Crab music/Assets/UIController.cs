using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour
{

    public static int score = 0;
    GameObject scoreText;

    public void AddScore()
    {
        score += 100;
    }

    public static int getscore()
    {
        return score;
    }

    void Start()
    {
        this.scoreText = GameObject.Find("Score");
    }

    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");
    }
}
