using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{  
    public Text leftScore;
    public Text rightScore;
    public Text score;
    public ScoreManager scoreManager;
    // Update is called once per frame
    void Update()
    {
        leftScore.text = scoreManager.leftScore.ToString();
        rightScore.text = scoreManager.rightScore.ToString();
        score.text = scoreManager.maxScore.ToString();
    }
}
