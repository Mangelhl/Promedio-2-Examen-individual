using UnityEngine;
using UnityEngine.UI;
using System;


public abstract class ScoreObserver
{
    public abstract void OnScoreChanged(int newScore);
}