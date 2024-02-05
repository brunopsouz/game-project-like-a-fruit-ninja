using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnBomb : MonoBehaviour
{
    [Header("Alvos")]
    [SerializeField] private GameObject prefab;

    [Header("Gameplay")]
    private float interval = 4f;
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float y;

    [Header("Dificult")]
    //[SerializeField] private float timeSpawn = 0.3f;
    //[SerializeField] private bool plusOneSpawn;

    [Header("Candies")]
    [SerializeField] private Sprite[] sprites;


    public static Scores score;

    private int tempoFase;


    public GameObject SpawnerBomb2;
    public GameObject SpawnerBomb3;
    public GameObject SpawnerBomb4;
    public GameObject SpawnerBomb5;



    void Start()
    {
        InvokeRepeating("Spawn", 4, interval);
        StartCoroutine("contagemSpawn");

        SpawnerBomb2.SetActive(false);
        SpawnerBomb3.SetActive(false);
        SpawnerBomb4.SetActive(false);
        SpawnerBomb5.SetActive(false);
    }


    void Update()
    {
        
    }

    public void Spawn()
    {
        //Instanciar e posicionar o objeto
        GameObject instance = Instantiate(prefab);
        instance.transform.position = new Vector2(Random.Range(minX, maxX), y);

        // Set parent
        instance.transform.SetParent(transform);

        // Seta um sprite
        Sprite randomSprite = sprites[Random.Range(0, sprites.Length)];
        instance.GetComponent<SpriteRenderer>().sprite = randomSprite;
    }

    IEnumerator contagemSpawn()
    {
        yield return new WaitForSeconds(1);
        tempoFase += 1;
        

        if (tempoFase > 0)
        {
            StartCoroutine("contagemSpawn");


            if (tempoFase > 12)
            {
                SpawnerBomb2.SetActive(true);
            }
           
            if (tempoFase > 24 )
            {
                SpawnerBomb3.SetActive(true);
            }
            if (tempoFase > 36)
            {
                SpawnerBomb4.SetActive(true);
            }
            if (tempoFase > 48)
            {
                SpawnerBomb5.SetActive(true);
            }

        }

    }

    IEnumerator Sprite()
    {
        yield return new WaitForSeconds(10);

        Sprite randomSprite = sprites[Random.Range(0, sprites.Length)];
        GetComponent<SpriteRenderer>().sprite = randomSprite;
        
    }
}



/*
 GameObject instance = Instantiate(prefab);
 instance.transform.position = new Vector2(Random.Range(minX, maxX), y);

 // Set parent
 instance.transform.SetParent(transform);

 Sprite randomSprite = sprites[Random.Range(0, sprites.Length)];
 instance.GetComponent<SpriteRenderer>().sprite = randomSprite;
*/