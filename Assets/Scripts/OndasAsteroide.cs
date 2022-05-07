using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OndasAsteroide : MonoBehaviour
{
    public comportamentoAsteroide prefabAsteroide; //Declaração do componente de Script (pega o prefab)
    public int quantidadeAsteroides = 100;

    void Start()
    {
        for (int i = 0; i < quantidadeAsteroides; i++) //Laço de Repetição 'for'(ESTUDEM!!!)
        {
            float x = Random.Range(-8.26f, 8.26f);
            float y = Random.Range(-4.38f, 4.38f);
            Vector3 posicao = new Vector3(x, y, 0.0f);
            Instantiate(prefabAsteroide, posicao, Quaternion.identity);
        }
    }
}