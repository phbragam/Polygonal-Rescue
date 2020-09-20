using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColetaItem : MonoBehaviour
{
    int pontuacao;
    public Text pontuacaoText;

    void Start()
    {
        pontuacao = 0;
        pontuacaoText.text = "Pontos: " + pontuacao.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Colisão aconteceu");
        if (other.CompareTag("ItemColetavel"))
        {
            Destroy(other.gameObject);
            pontuacao++;
            pontuacaoText.text = "Pontos: " + pontuacao.ToString();
        }
    }
}
