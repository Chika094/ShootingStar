using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Create : MonoBehaviour
{
    public GameObject enemy;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject charge;
    
    void Start()
    {  
        InvokeRepeating("Ecriate", 1, 3.0f);
        InvokeRepeating("Ecriate", 11, 3.0f);
        InvokeRepeating("Ecriate", 60, 3.0f);
        InvokeRepeating("E2criate", 50, Random.Range(10.0f, 15.0f));
        InvokeRepeating("E3criate", 20, Random.Range(10.0f, 15.0f));
        InvokeRepeating("Ccriate", 1, 4.0f);
    }

    void Ccriate()
    {
        Vector3 pos = this.transform.position;
        pos.z = -20.5f;
        pos.y = Random.Range(2.0f, 22.0f);
        charge.transform.position = pos;
        Instantiate(this.charge);
    }
    void Ecriate()
    {
        Vector3 pos = this.transform.position;
        pos.z = -20.5f;
        pos.y = Random.Range(2.0f, 22.0f);
        enemy.transform.position = pos;
        Instantiate(this.enemy);
    }

    void E2criate()
    {
        Vector3 pos = this.transform.position;
        float rot = -32.0f;

        pos.z = -20.5f;
        pos.y = 10.0f;
        enemy2.transform.position = pos;

        for (int i = 0 ; i < 4 ; i++) //•úŽËüó‚É‚È‚é‚æ‚¤‚É”z’u
        {
            rot += 15.0f;
            enemy2.transform.rotation = Quaternion.Euler(rot, 90.0f, 0.0f);
            Instantiate(this.enemy2);
        }
    }
    void E3criate()
    {
        Vector3 pos = this.transform.position;
        pos.y = Random.Range(2.0f, 22.0f);
        pos.z = -20.5f;
        enemy3.transform.position = pos;
        Instantiate(this.enemy3);
    }
}
