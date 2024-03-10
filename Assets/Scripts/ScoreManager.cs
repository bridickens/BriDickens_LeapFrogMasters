using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    public Text scoreTextP2;
    public int score = 0;
    public int score2 = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "P1 Score: " + score.ToString();
        scoreTextP2.text = "P2 Score: " + score2.ToString();

    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = "P1 Score: " + score.ToString();
        if(score == 5)
        {
            SceneManager.LoadScene("P1WinScene");
        }
    }
    public void AddPointP2()
    {
        score2 += 1;
        scoreTextP2.text = "P2 Score: " + score2.ToString();
        if (score2 == 5)
        {
            SceneManager.LoadScene("P2WinScene");
        }
    }
}
