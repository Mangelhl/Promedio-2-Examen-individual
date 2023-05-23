using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : Singleton<ScoreManager>
{
    private int score;
    private List<Action<int>> scoreObservers = new List<Action<int>>();
    

    public int Score => score;    

    public void AddScoreObserver(Action<int> observer)
    {
        scoreObservers.Add(observer);
    }

    public void RemoveScoreObserver(Action<int> observer)
    {
        scoreObservers.Remove(observer);
    }

    public void ModificadorPuntaje(int amount)
    {
        score += amount;
        NotifyScoreObservers();
    }        
    private void NotifyScoreObservers()
    {
        foreach (var observer in scoreObservers)
        {
            observer.Invoke(score);
        }
    }
}
