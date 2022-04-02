using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamento : MonoBehaviour
{
    [SerializeField] public float aceleracao = 3.0f ;
    public float rotacao = 180.0f;
    public float velMax = 10.0f;
    public Rigidbody2D jogadorRb;


    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 direcao = transform.up * aceleracao;
            // Vector3 direcao = new Vector3 (0.0f, 1.0f * aceleracao, 0.0f);
            jogadorRb.AddForce(direcao, ForceMode2D.Force);//Adicionar força na movimentacao, efeito mais suave
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 direcao = transform.up * -aceleracao;
            // Vector3 direcao = new Vector3 (0.0f, 1.0f * aceleracao, 0.0f);
            jogadorRb.AddForce(direcao, ForceMode2D.Force);//Adicionar força na movimentacao, efeito mais suave
        }
        if (Input.GetKey(KeyCode.A))
        {
            jogadorRb.rotation += rotacao * Time.deltaTime;
            // joggadorRb.rotation = jogadorRb.rotation + (180.0f * Time.deentaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            jogadorRb.rotation += -rotacao * Time.deltaTime;
            // joggadorRb.rotation = jogadorRb.rotation + (180.0f * Time.deentaTime);
        }
        if (jogadorRb.velocity.magnitude > velMax)
        {
            jogadorRb.velocity = Vector2.ClampMagnitude(jogadorRb.velocity, velMax);
        }
    }
}
