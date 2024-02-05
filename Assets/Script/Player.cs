using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]

    public Collider2D collider2d;
    public Vector3 wp;

    private Scores score;

    private HeartsTest maxLife;

    private ImageRandom img;

    private HeartsTest gameOver;


    void Awake()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Scores>() as Scores;
       // life = GameObject.FindGameObjectWithTag("Life").GetComponent<Life>() as Life;
        maxLife = GameObject.FindGameObjectWithTag("MaxLife").GetComponent<HeartsTest>() as HeartsTest;
       // gameOver = GameObject.FindGameObjectWithTag("gameOver").GetComponent<HeartsTest>() as GameOver;

    }
    void Start()
    {
        collider2d = GetComponent<Collider2D>();
        img = FindObjectOfType<ImageRandom>();
        gameOver = GetComponent<HeartsTest>();
    }

    
    void Update()
    {
        collider2d.enabled = false;

        for (int i = 0; i < Input.touchCount; ++i)
        {
            collider2d.enabled = true;

            wp = Camera.main.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y,0));

            transform.position = new Vector2(wp.x, wp.y);
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Candy")
        {
            //Debug.Log("SORTEADO: " + other.GetComponent<MoveObject>().tipo);
            //Debug.Log("DEVE CLICAR: " + img.tipo);

            if (other.GetComponent<MoveObject>().tipo == img.tipo)
            {
                score.Hit();
                other.GetComponent<MoveObject>().TestDestroy();

            } else if (other.GetComponent<MoveObject>().tipo != img.tipo)
            {
                maxLife.HitBomb();
                other.GetComponent<MoveObject>().TestDestroy(); 
                score.Recorde();
            }
        }

        if (other.tag == "Bomb") 
        {
            maxLife.ClickBomb();
            other.GetComponent<MoveObject>().TestDestroy();
            score.Recorde();
        }
    }




    //void LoadLevel()
    //{
       // Application.LoadLevel("Menu");
   // }

}