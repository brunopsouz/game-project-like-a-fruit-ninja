using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner2 : MonoBehaviour
{

    [Header("Alvos")]
    [SerializeField] private GameObject prefab;

    [Header("Gameplay")]
    public float interval = 1.8f;
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float y;

    [Header("Candies")]
    public Sprite[] spritesB;
    
    public List<Sprite> coresB;

    /* ***************************************************************** */

    public bool found;


    void Start()
    {
        InvokeRepeating("RandomSprite", interval, interval);
    }


    public bool RandomSprite(Sprite[] sprites, Sprite[] spritesB)
    {
        found = true;

        //Instanciar e posicionar o objeto
        GameObject instance = Instantiate(prefab);
        instance.transform.position = new Vector2(Random.Range(minX, maxX), y);


        // Set parent
        instance.transform.SetParent(transform);

        // Seta um sprite
        Sprite randomSprite = spritesB[Random.Range(0, spritesB.Length)];
        instance.GetComponent<SpriteRenderer>().sprite = randomSprite;
        

        if (sprites.Length != spritesB.Length)
            return false;

        for (int i = 0; i < sprites.Length; i++)
        {
            found = false;
            for (int u = 0; u < spritesB.Length; u++)
            {
                if (sprites[i] == spritesB [u])
                {
                    found = true;
                    break;
                }
            }
        }
        if (!found)
        {
            return false;
        }
        return true;
        
    }

}
