using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{

    private int recorde;
    private static int score = 0;
    public GameObject textScore;
    
    public Text txtScore;

    public SpawnBomb IBomb;

    public int idResp;

    void Start()
    {
        score = 0;
        txtScore.text = "0";
        Recorde();
 
    }

    void Update()
    {
     
    }

    public void Hit()
    {
        ++score;
        txtScore.text = score.ToString();
    }

    public void Recorde()
    {
        if (score > PlayerPrefs.GetInt ("Recorde"))
        {
            PlayerPrefs.SetInt("Recorde", score);
        }

        if(textScore != null)
        {
            textScore.GetComponent<Text>().text = "Recorde" + " " + PlayerPrefs.GetInt("Recorde").ToString();
        }
    }

}
