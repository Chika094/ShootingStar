using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startbuttonscript : MonoBehaviour
{
    public void OnClickStartButton()
    {
        GetComponent<AudioSource>().Play();
        StartCoroutine("wait");
    }

    IEnumerator wait() //1.5�b�ҋ@��ɃV�[���J��
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("main");
    }
}
