using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    private float fspeed = 1.2f;
    private Image black;
    private float alpha;
    private bool fout = false;
    private bool fin = true;

    void Start()
    {
        black = this.GetComponent<Image>();
        alpha = 1.0f;
        black.color = new Color(0.0f, 0.0f, 0.0f, alpha);
    }
    void Update()
    { 
    
        if(fout == true) // フェードアウト
        {
            alpha += Time.deltaTime * fspeed;
            black.color = new Color(0.0f, 0.0f, 0.0f, alpha);
            if (alpha >= 1)
            {
                fout = false;
                SceneManager.LoadScene("end");
            }
        }

        if (fin == true) // フェードイン
        {
            alpha -= Time.deltaTime * fspeed;
            black.color = new Color(0.0f, 0.0f, 0.0f, alpha);
            if (alpha <= 0)
            {
                fin = false;
            }
        }
    }

    public void fout_to_true()
    {
        fout = true;
    }

}

