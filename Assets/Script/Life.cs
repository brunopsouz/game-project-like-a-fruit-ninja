using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public Image[] life;
    private int quantityLife;
    private int index = 0;
    public Image guiTexture;

    void Start()
    {
        guiTexture = life[0];
        quantityLife = life.Length;
    }
    
    
    void Update()
    {
        
    }

    public bool Remove()
    {
        if ((quantityLife < 0))
        {
            return false;
        }
        if (index < (quantityLife - 1))
        {
            index += 1;
            guiTexture = life[index];
            return true;
         }
        else
        {
            return false;
        }
    }
}
