using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chargescript : MonoBehaviour
{
    private float speed;

    void Start()
    {
        speed = Random.Range(-2.0f, -2.8f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
