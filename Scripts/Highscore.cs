using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    private int highscore;
    private Text Score;

    void Start()
    {
        Score = this.GetComponent<Text>();
        highscore = PlayerPrefs.GetInt("SCORE", 0);
        Score.text = highscore.ToString();
    }
}
