using UnityEngine;
using UnityEngine.UI;

public class ScoreManager02 : MonoBehaviour
{

    [Header("分數介面1.0")]
    public Text textScore01;
    [Header("分數介面2.0")]
    public Text textScore02;
    [Header("分數")]
    public int score01;
    [Header("投進的分數")]
    static public int scoreIn = 1;
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
        if (other.tag == "paperball" && other.transform.position.y > 1.0f)
        {
            Addscore();
            Destroy(other);
        }
    }
        private void Addscore()
        {
            ///遞增+2
            score01 += scoreIn;
            textScore01.text = "分數:" + score01;
            textScore02.text = "分數:" + score01;
            aud.PlayOneShot(soundIn, Random.Range(0.3f, 0.8f));
        }



    }
