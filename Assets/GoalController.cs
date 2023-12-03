using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider2D ball;
    public bool left;
    public ScoreManager scoreManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if (left)
            {
                scoreManager.AddLeftScore(1);
            }
            else
            {
                scoreManager.AddRightScore(1);
            }
        }
    }
}
