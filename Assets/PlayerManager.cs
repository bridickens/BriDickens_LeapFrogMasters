using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour, IGameManager
{
    public Text scoreText;
    public Text scoreTextP2;
    public ManagerStatus status { get; private set; }

    public int score { get; private set; }
    public int maxScore { get; private set; }

    public int scoreP2 { get; private set; }
    public int maxScoreP2 { get; private set; }

    public void Startup()
    {
        Debug.Log("Player manager starting...");

        score = 0;
        maxScore = 5;

        scoreText.text = "P1 Score: " + score.ToString();
        scoreTextP2.text = "P2 Score: " + scoreP2.ToString();

        status = ManagerStatus.Started;
    }

    public void ChangeScoreP1(int value)
    {
        score += value;
        scoreText.text = "P1 Score: " + score.ToString();
        if (score >= maxScore)
        {
            SceneManager.LoadScene("P1WinScene");
        }
        else if (score < 0)
        {
            score = 0;
        }

        Debug.Log($"Health: {score}/{maxScore}");

    }

    public void ChangeScoreP2(int value)
    {
        scoreP2 += value;
        scoreTextP2.text = "P2 Score: " + scoreP2.ToString();
        if (scoreP2 >= maxScoreP2)
        {
            SceneManager.LoadScene("P2WinScene");
        }
        else if (scoreP2 < 0){
           scoreP2 = 0;
        }

        Debug.Log($"Health: {scoreP2}/{maxScoreP2}");

    }
}
