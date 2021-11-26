using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gotitle : MonoBehaviour
{
    public void OnClickBackButton()
    {
        GetComponent<AudioSource>().Play();
        StartCoroutine("wait");
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("start");
    }
}
