using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zumbi : MonoBehaviour
{
	private bool andando = false;
	public float delayAndar = 1.5f;

	public Rigidbody rb;
	public float velocidade = 0.35f;

	private GameObject jogador;

	// Use this for initialization
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

	// Update is called once per frame
	private void Update()
	{
		if (andando)
		{
			rb.velocity = (jogador.transform.position - transform.position).normalized * velocidade;
		}
	}
}
