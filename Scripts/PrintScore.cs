using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintScore : MonoBehaviour
{
    private int score;
    private Text Score;

    void Start()
    {
        Score = this.GetComponent<Text>();
        score = PlayerPrefs.GetInt("FSCORE", 0);
        Score.text = score.ToString();
    }
}
