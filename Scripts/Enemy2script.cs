using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2script : MonoBehaviour
{
    private GameObject Score;
    private float speed;

    void Start()
    {
        speed = -2.8f;
        Score = GameObject.Find("numScore");
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Bullet")
        {
            Score.GetComponent<Scorescript>().addEscore();
            Destroy(gameObject);
        }
    }
}
