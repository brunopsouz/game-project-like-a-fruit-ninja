using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeTest : MonoBehaviour
{
    public int quantMaxCoracao = 5;
    public int inicioQuantCor = 3;
    public int quantPedacosC = 4;
    public Image[] containers;
    public Sprite[] spriteCoracao;

    public int vidaAtual;
    public int maxVida;

    void Start()
    {
        QuantidadeVida();
    }

    
    void Update()
    {
        
    }

    void QuantidadeVida()
    {
        for (int i = 0; i < quantMaxCoracao; i++)
        {
            if (inicioQuantCor <= i)
            {
                containers[i].enabled = false;
            }
            else
            {
                containers[i].enabled = true;
            }
        }
        Coracoes();
    }


    void Coracoes()
    {
        bool vazio = false;
        int x = 0;

        foreach (Image imagem in containers)
        {
            if (vazio)
            {
                imagem.sprite = spriteCoracao[0];
            }
            else
            {
                x++;

                if (vidaAtual >= x * quantPedacosC)
                {
                    imagem.sprite = spriteCoracao[4];
                }
                else
                {
                    int coracoesAtual = (int)(quantPedacosC - (quantPedacosC * x - vidaAtual));
                    int vidaImagem = quantPedacosC / (spriteCoracao.Length - 1);
                    int id = coracoesAtual / vidaImagem;
                    imagem.sprite = spriteCoracao[id];
                    vazio = true;
                }
            }
        }
    }

    void Dano(int d)
    {
        if (vidaAtual > 0)
        {
            vidaAtual -= d;
        }
        Coracoes();
    }

    void MaisCoracao()
    {
        if (inicioQuantCor < quantMaxCoracao)
        {
            inicioQuantCor++;
        }

        CalculaValoresVida();
    }

    void CalculaValoresVida()
    {
        vidaAtual = inicioQuantCor * quantPedacosC;
        maxVida = quantMaxCoracao * quantPedacosC;

        QuantidadeVida();
    }
}
