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
        transform.Translate(Vector3.forward * velocidade * Time.smoothDeltaTime);
    }
}