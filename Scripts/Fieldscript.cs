using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fieldscript : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Bullet" || collider.gameObject.tag == "Enemy")
        {
            Destroy(collider.gameObject);
        }
    }
}
