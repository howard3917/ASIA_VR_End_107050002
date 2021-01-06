using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    [Header("分數介面1.0")]
    public Text textScore01;
    [Header("分數介面2.0")]
    public Text textScore02;
    [Header("分數")]
    public int score;
    [Header("投進的分數")]
    public int scoreIn = 2;
    [Header("進球音效")]
    public AudioClip soundIn;

    private AudioSource aud;

    private void Awake()
    {
        //音效來源 = 取得元件
        aud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="paperball" && other.transform.position.y >1.0f)
        {
            Addscore();
            Destroy(other);
        }
        //如果 碰撞的物件名稱是player
        if(other.transform.root.name == "Player")
        {
            //玩家進入區域 將投進的分數改為五分
            scoreIn = 5;
        }
    }

    //當碰撞物件離開碰撞範圍時執行一次
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.root.name == "player")
        {
            //玩家進入區域 將投進的分數改為五分
            scoreIn = 2;
        }
    }
    
    private void Addscore()
    {
        ///遞增+2
        score += scoreIn;
        textScore01.text = "分數:" + score;
        textScore02.text = "分數:" + score;
        aud.PlayOneShot(soundIn, Random.Range(0.3f, 0.8f));
    }


}
