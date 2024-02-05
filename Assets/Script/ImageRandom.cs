using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enuns;

public class ImageRandom : MonoBehaviour
{
    //public Sprite[] sprites;

    private int tempoFase;

    public Candy[] candiesB;
    public EnumSprite tipo;


    //public List<Sprite> cores;

    //private Sprite idResposta;

    void Start()
    {
        //spriteRender = GetComponent<SpriteRenderer>();
        StartCoroutine("ImgRandom");
        StartCoroutine("contagemSpawn");
        InvokeRepeating("ImgRandom", 0,1);
        
        
    }

    IEnumerator contagemSpawn()
    {
        yield return new WaitForSeconds(1);
        tempoFase += 1;
       
    }
    
    IEnumerator ImgRandom()
    {
        do
        {
            yield return new WaitForSeconds(6);

            //GameObject instance = Instantiate(gameObject);
            //instance.transform.SetParent(transform);
            Candy randomCandiesB = candiesB[Random.Range(0, candiesB.Length)];
            GetComponent<SpriteRenderer>().sprite = randomCandiesB.sprites;

            tipo = randomCandiesB.tipo;

            //Debug.Log(tipo);

            //cores.Add(randomSprite);
        }
        while (tempoFase > 0);
    }

}
