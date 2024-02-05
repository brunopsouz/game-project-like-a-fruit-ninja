using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enuns;

public class MoveObject : MonoBehaviour
{
    [Header("Velocity")]
    [SerializeField]
    private float minX;
    [SerializeField]
    private float maxX;
    [SerializeField]
    private float minY;
    [SerializeField]
    private float maxY;

    [Header("Gameplay")]
    [SerializeField]
    private float lifeTime;

    [Header("Component")]
    private Collider2D collider2d;

    public EnumSprite tipo;


    void Start()
    {
        Move();
    }


    void Update()
    {

  
    }

    public void Move()
    {
        collider2d = GetComponent<Collider2D>();

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(
            Random.Range(minX, maxX),
            Random.Range(minY, maxY)
            );

        Destroy(gameObject, lifeTime);

    } 
    
    public void TestDestroy()
    {
        if (gameObject.CompareTag("Candy"))
        {
            Destroy(gameObject);
        }else if (gameObject.CompareTag("Bomb"))
        {
            Destroy(gameObject);
        }
    }

}

