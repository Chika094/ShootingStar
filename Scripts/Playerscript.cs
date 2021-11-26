using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscript : MonoBehaviour
{
    private float xspeed; //横スクロール速さ
    private float speed;
    private float yspeed = 10.0f;//飛ぶ速さ
    private float jumpspeed = 2.0f;//ジャンプの速さ
    private int charge = 0;//弾のチャージ
    private int cnum = 3;//チャージに必要な個数
    public GameObject bullet;
    private GameObject fade;
    private GameObject score;
    public AudioClip endsound;
    public AudioClip getsound;

    private int highscore;

    //チャージを可視化するためのSprite
    private GameObject chr1;
    private GameObject chr2;
    private GameObject chr3;

    private float sTime;//時間

    void Start()
    {
        xspeed = 1.5f;

        highscore = PlayerPrefs.GetInt("SCORE", 0);
         
        fade = GameObject.Find("Fade");
        score = GameObject.Find("numScore");
        chr1 = GameObject.Find("Charge1");
        chr2 = GameObject.Find("Charge2");
        chr3 = GameObject.Find("Charge3");
        DisplayOff();
    }

    void Update()
    {
        sTime += Time.deltaTime;

        Vector3 pos = this.transform.position;
        speed = xspeed * Time.deltaTime;
        pos.x += speed;

        //spaceボタンで飛行
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().useGravity = false;//重力オフ
            this.GetComponent<Rigidbody>().velocity = Vector3.up * jumpspeed;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().useGravity = true;//重力オン
        }
        if (Input.GetKey(KeyCode.Space))
        {
            pos.y += yspeed * Time.deltaTime;
        }

        //弾を出す
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (charge == cnum)
            {
                GetComponent<AudioSource>().Play();
                Vector3 bpos = this.transform.position;
                bpos.x += 1.0f;
                bpos.y -= 1.5f;
                bullet.transform.position = bpos;
                Instantiate(this.bullet);
                charge = 0;
                DisplayOff();
            }
            
        }

        this.transform.position = pos;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            GetComponent<AudioSource>().PlayOneShot(endsound);
            int fscore = score.GetComponent<Scorescript>().getScore(); //最終的なスコア
            if (highscore < fscore)
                highscore = fscore;

            PlayerPrefs.SetInt("SCORE", highscore);
            PlayerPrefs.SetInt("FSCORE", fscore);
            fade.GetComponent<Fade>().fout_to_true();
        }

        if (collider.gameObject.tag == "Charge")
        {
            if(charge < cnum)
            {
                GetComponent<AudioSource>().PlayOneShot(getsound);
                charge++;
                DisplayOn(charge);                
            }
            Destroy(collider.gameObject);
        }
    }

    //引数と同じ番号のチャージを表示
    void DisplayOn(int i)
    {
        if(i == 1)
        {
            chr1.SetActive(true);
        }else if(i == 2){
            chr2.SetActive(true);
        }else if (i == 3)
        {
            chr3.SetActive(true);
        }
    }

    //チャージの表示をすべてなくす
    void DisplayOff()
    {
        chr1.SetActive(false);
        chr2.SetActive(false);
        chr3.SetActive(false);
    }

    public float GetSpeed()
    {
        return speed;
    }
}
