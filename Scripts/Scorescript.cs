using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class Scorescript : MonoBehaviour
{
    public Enemyscript enemyscript;
    private Text Scoretext;
    private int Score;
    private int eScore;　//飛んでくる弾を消したときの加点
    private float sTime;
    private int maxscore = 999999;

    public void Start()
    {
        Score = 0;
        eScore = 0;
        Scoretext = this.GetComponent<Text>();
    }

    // Update is called once per frame
    public void Update()
    {
        Scoretext.text = Score.ToString();
        sTime += Time.deltaTime;
   
        // スコア ＝ eスコア×5 + 経過時間
        Score = (int)sTime + eScore*5;

        if (Score > maxscore) //スコアが999999でカンスト
            Score = maxscore;
    }

    public void addEscore()
    {
        eScore++;
    }

    public int getScore()
    {
        return Score;
    }
}
