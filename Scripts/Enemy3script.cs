using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3script : Enemyscript
{
    private bool up = true;

    void Start()
    {
        base.Start();
        speed = -0.5f;        
    }

    void Update()
    {
        base.Update();
        if (up)
        {
            pos.y += 0.35f * Time.deltaTime;
            if (pos.y >= 23.0f)
                up = false;
        }
        else
        {
            pos.y -= 0.2f * Time.deltaTime;
            if(pos.y <= 0.5)
            {
                up = true;
            }
        }
        this.transform.position = pos;
    }

    protected override void decide_xspeed(double rand)
    {
        xspeed = speed * (float)rand;
    }
}
