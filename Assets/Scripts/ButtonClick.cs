using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{   
    public void OnClick()
    {
        ScoreManager.Instance.IncrementScore1(1);
    }
    public void OnClick2()
    {
        ScoreManager.Instance.IncrementScore2(1);
    }
    public void OnClick3()
    {
        ScoreManager.Instance.IncrementScore3(1);
    }   
}
