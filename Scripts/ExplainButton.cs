using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplainButton : MonoBehaviour
{
    private GameObject illust;
    private bool active = false;
    
    void Start()
    {
        illust = GameObject.Find("ExImage");
        illust.SetActive(false);
    }

    public void OnClickExplainButton()
    {
        GetComponent<AudioSource>().Play();

        if (active == true)
        {
            illust.SetActive(false);
            active = false;
        }
        else
        {
            illust.SetActive(true);
            active = true;
        }
    }
}
