using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }
    public int Score { get; private set; }
    public int Score2 { get; private set; }
    public int Score3 { get; private set; }

    public event Action<int> ScoreChanged;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        // Encuentra el objeto de texto en la escena y actualiza su texto con el puntaje actual.
        GameObject scoreTextObj = GameObject.Find("ScoreText");
        Text scoreText = scoreTextObj.GetComponent<Text>();
        scoreText.text = "Score: " + Score.ToString();

        GameObject scoreTextObj2 = GameObject.Find("ScoreText2");
        Text score2Text = scoreTextObj2.GetComponent<Text>();
        score2Text.text = "Score2: " + Score2.ToString();

        GameObject scoreTextObj3 = GameObject.Find("ScoreText3");
        Text score3Text = scoreTextObj3.GetComponent<Text>();
        score3Text.text = "Score3: " + Score3.ToString();
    }

    public void IncrementScore1(int incrementAmount)
    {
        Score += incrementAmount;
        ScoreChanged?.Invoke(Score);
        UpdateScoreUI();
    }

    public void IncrementScore2(int incrementAmount)
    {
        Score2 += incrementAmount;
        ScoreChanged?.Invoke(Score2);
        UpdateScoreUI();
    }

    public void IncrementScore3(int incrementAmount)
    {
        Score3 += incrementAmount;
        ScoreChanged?.Invoke(Score3);
        UpdateScoreUI();
    }
}
