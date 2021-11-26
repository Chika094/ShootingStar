using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private Playerscript playerscript;

    void Start()
    {
        playerscript = GameObject.Find("Player").GetComponent<Playerscript>();
    }

    void Update()
    {
        Vector3 pos = this.transform.position;

        pos.x += playerscript.GetSpeed();
        this.transform.position = pos;
    }
}
