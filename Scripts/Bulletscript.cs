using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletscript : MonoBehaviour
{
    void Start()
    {
        this.GetComponent<Rigidbody>().velocity = new Vector3(15.0f, 0.0f, 0.0f);
    }

}
