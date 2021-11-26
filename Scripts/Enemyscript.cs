using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyscript : MonoBehaviour
{
    protected GameObject Score;
    protected float speed;
    protected float xspeed;
    protected Vector3 pos;

    protected void Start()
    {
        speed = -1.0f;
        double rand = UnityEngine.Random.Range(1, 4);
        Score = GameObject.Find("numScore");
        decide_xspeed(rand);
    }

    protected void Update()
    { 
        pos = this.transform.position;
        pos.x += xspeed;
        this.transform.position = pos;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Bullet")
        {
            Score.GetComponent<Scorescript>().addEscore();
            Destroy(gameObject);
        }
    }

    protected virtual void decide_xspeed(double rand)
    {
        long score = Score.GetComponent<Scorescript>().getScore();//スコア値を取得

        if (score < 50)
            xspeed = speed * (float)rand * Time.deltaTime;
        else if (score < 100)
            xspeed = (speed * (float)rand - 0.3f) * Time.deltaTime;
        else
            xspeed = (speed * (float)rand - 0.5f) * Time.deltaTime;
    }
}

