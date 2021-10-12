using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIScore : MonoBehaviour
{
    public Text score;
    public ScoreCount sc;

    void Update()
    {
        score.text = sc.GetCurrentScore().ToString();
    }
}