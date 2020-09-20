using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarPrefabs : MonoBehaviour
{
    public List<GameObject> prefabs_base; // Lista dos preabs base para a criação de instâncias
    //public float distancia_maxima; // Distância máxima do centro deste GameObject até a posição onde os objetos serão instanciados
    public float largura;
    public float comprimento;
    public int quantidade; // É a quantidade de instâncias que pretendemos criar

    private void Awake()
    {
        Vector3 centro = transform.position;

        for (int i = 0; i < quantidade; i++)
        {
            int indice_aleatorio = Random.Range(0, prefabs_base.Count);
            GameObject prefab_escolhido = prefabs_base[indice_aleatorio];

            Vector3 posicao_da_instancia = new Vector3();

            posicao_da_instancia.x = Random.Range((centro.x - largura/2), (centro.x + largura/2));
            posicao_da_instancia.y = centro.y;
            posicao_da_instancia.z = Random.Range((centro.z - comprimento/2), (centro.z + comprimento/2));

            Instantiate(prefab_escolhido, posicao_da_instancia, Quaternion.identity);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        //Gizmos.color = new Color(255, 255, 0, .5f);

        Vector3 centro = transform.position;

        //Vector3 final_da_linha = new Vector3(centro.x + 10, centro.y, centro.z);
        //Gizmos.DrawLine(centro, final_da_linha);

        Vector3 A = new Vector3(centro.x - largura / 2, centro.y, centro.z - comprimento / 2);
        Vector3 B = new Vector3(centro.x + largura / 2, centro.y, centro.z - comprimento / 2);
        Vector3 C = new Vector3(centro.x + largura / 2, centro.y, centro.z + comprimento / 2);
        Vector3 D = new Vector3(centro.x - largura / 2, centro.y, centro.z + comprimento / 2);

        Gizmos.DrawLine(A, B);
        //Gizmos.color = Color.blue;
        Gizmos.DrawLine(B, C);
        //Gizmos.color = Color.red;
        Gizmos.DrawLine(C, D);
        Gizmos.DrawLine(D, A);

        //Vector3 cubeDimensions = new Vector3(largura, .1f, comprimento);

        //Gizmos.DrawCube(centro, cubeDimensions);
    }
}
