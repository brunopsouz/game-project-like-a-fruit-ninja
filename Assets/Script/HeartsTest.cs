using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartsTest : MonoBehaviour
{
    public Text txtMaxLife;
    private static int maxLife = 3;

    public Image img;

    public Transform gameOver;

    public Player player;

    void Start()
    {
        maxLife = 3;
        txtMaxLife.text = "3";
        player = GetComponent<Player>();
        //img.fillAmount = 1;
    }

    public void HitBomb()
    {
        --maxLife;
        txtMaxLife.text = maxLife.ToString();

        if (maxLife == 0)
        {
            gameOver.gameObject.SetActive(true);
            Invoke("Pause", 1);
        }


        //img.fillAmount = -0.3f;

        // if (img.fillAmount == 0f)
        //{
        //  Debug.Log("GAME OVER!!!");
        //}
    }

    void Pause()
    {
        Time.timeScale = 0;
    }

    public void ClickBomb()
    {
        gameOver.gameObject.SetActive(true);
        maxLife = 0;
        txtMaxLife.text = "0";
        Invoke("Pause", 1);  
    }

}
