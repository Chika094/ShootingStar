using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundscript : MonoBehaviour
{
    private float gwide = 100;
    private GameObject Camera;

    void Start()
    {
        Camera = GameObject.Find("Main Camera");
    }

    void Update()
    {
        Vector3 posg = this.transform.position;
        Vector3 posc = Camera.transform.position;

        if(posc.x-posg.x > 100)
        {
            posg.x += gwide * 3;
            this.transform.position = posg;
        }
    }
}
