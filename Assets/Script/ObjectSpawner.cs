using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Enuns;

public class ObjectSpawner : MonoBehaviour
{
    [Header("Alvos")]
    [SerializeField] private GameObject prefab;

    [Header("Gameplay")]
    public float interval = 1.8f;
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float y;

    [Header("Candies")]
    public Candy[] candies;
    //public Sprite[] spritesB;


    void Start()
    {
        InvokeRepeating("Spawn", interval, interval);
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
        Candy randomCandy = candies[Random.Range(0, candies.Length)];
        instance.GetComponent<SpriteRenderer>().sprite = randomCandy.sprites;
        //coresB.Add(randomSprite);
        //yield return new WaitForSeconds(5);

        instance.GetComponent<MoveObject>().tipo = randomCandy.tipo;

        //Debug.Log(instance.GetComponent<MoveObject>().tipo);
    }

}

/*
    GameObject instance = Instantiate(prefab);
   instance.transform.position = new Vector2(Random.Range(minX, maxX), y);


   // Set parent
   instance.transform.SetParent(transform);

   // Seta um sprite
   Sprite randomSprite = spritesB[Random.Range(0, spritesB.Length)];
   instance.GetComponent<SpriteRenderer>().sprite = randomSprite;
   //coresB.Add(randomSprite);
   //yield return new WaitForSeconds(5);
   */


/* GameObject instance = Instantiate(prefab);
instance.transform.position = new Vector2(Random.Range(minX, maxX), y);


// Set parent
instance.transform.SetParent(transform);

// Seta um sprite
Sprite randomSprite = spritesB[Random.Range(0, spritesB.Length)];
instance.GetComponent<SpriteRenderer>().sprite = randomSprite;
coresB.Add(randomSprite); */