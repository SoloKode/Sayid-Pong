using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int rightScore;
    public int leftScore;
    public int maxScore;
    public BallController ball;
    public void AddRightScore(int i)
    {
        rightScore += i;
        ball.ResetBall();
        if (rightScore >= maxScore)
        {
            GameOver();
        }
    }
    public void AddLeftScore(int i)
    {
        leftScore += i;
        ball.ResetBall();
        if (leftScore >= maxScore)
        {
            GameOver();
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene(0);
    }

}
