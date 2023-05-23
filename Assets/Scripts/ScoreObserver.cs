using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreObserver : MonoBehaviour
{
    private ScoreUI scoreUI;
    private void Start()
    {
        scoreUI = GetComponent<ScoreUI>();
        ScoreManager.Instance.AddScoreObserver(OnScoreChanged);
    }    
    private void OnDestroy()
    {
        if (ScoreManager.Instance != null)
        {
            ScoreManager.Instance.RemoveScoreObserver(OnScoreChanged);
        }
    }

    private void OnScoreChanged(int score)
    {
        scoreUI.UpdateScore(score);
    }
}
