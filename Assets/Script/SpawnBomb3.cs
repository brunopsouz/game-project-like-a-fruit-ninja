using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBomb3 : MonoBehaviour
{

    [Header("Alvos")]
    [SerializeField] private GameObject prefab;

    [Header("Gameplay")]
    private float interval = 2.5f;
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
   
    void Start()
    {

        InvokeRepeating("Spawn", interval, interval);
        

    }

    // Update is called once per frame
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
}
