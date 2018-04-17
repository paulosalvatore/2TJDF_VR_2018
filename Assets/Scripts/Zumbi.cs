using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zumbi : MonoBehaviour
{
    [Header("Movimentação")]
    public float delayAndar = 1.5f;
    public float delayRecuperacao = 1f;
    public float velocidade = 0.35f;
    private bool andando = false;

    [Header("Vida")]
    [Range(2, 10)]
    public int hp = 2;

    [Header("Componentes")]
    public Rigidbody rb;
    public Animator animator;
    private GameObject jogador;

    private void Start()
    {
        jogador = GameObject.FindGameObjectWithTag("Player");

        transform.LookAt(jogador.transform);

        Invoke("Andar", delayAndar);
    }

    private void Andar()
    {
        andando = true;
    }

    private void Update()
    {
        if (andando)
        {
            rb.velocity = (jogador.transform.position - transform.position).normalized * velocidade;
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (andando && collider.CompareTag("Projétil"))
        {
            Destroy(collider.gameObject);

            if (hp > 1)
                AplicarDano();
            else
                Matar();
        }
    }

    private void Matar()
    {
        hp--;
        andando = false;
        animator.SetTrigger("Die");
    }

    private void AplicarDano()
    {
        hp--;
        andando = false;
        Invoke("Andar", delayRecuperacao);
        animator.SetTrigger("Damage");
    }
}