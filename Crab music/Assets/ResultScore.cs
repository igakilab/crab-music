using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResultScore : MonoBehaviour
{
    int score;
    GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = UIController.getscore();
        this.scoreText = GameObject.Find("resultScore");
    }

    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");
    }
}
