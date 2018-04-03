using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
	public float velocidade = 5f;

	private void Start()
	{
		Destroy(gameObject, 5f);
	}

	private void Update()
	{
		transform.Translate(transform.forward * velocidade * Time.smoothDeltaTime);
	}
}
