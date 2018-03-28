using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
	public float velocidade = 5f;

	private void Start()
	{
	}

	private void Update()
	{
		transform.Translate(transform.forward * velocidade * Time.smoothDeltaTime);
	}
}
