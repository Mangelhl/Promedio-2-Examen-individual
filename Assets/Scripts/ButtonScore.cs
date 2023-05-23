using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScore : MonoBehaviour
{
    public int modificadorScore;

    public void OnClick()
    {
        ScoreManager.Instance.ModificadorPuntaje(modificadorScore);
    }
   
}
