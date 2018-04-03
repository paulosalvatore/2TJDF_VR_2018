using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorZumbis : MonoBehaviour
{
    public float intervalo = 3f;
    public float area = 4f;
    public GameObject zumbiPrefab;

    // Use this for initialization
    private void Start()
    {
        InvokeRepeating("GerarZumbi", intervalo, intervalo);
    }

    private void GerarZumbi()
    {
        GameObject zumbi = Instantiate(zumbiPrefab);
        Vector2 posicaoAleatoria = Random.insideUnitCircle * area;
        zumbi.transform.position = new Vector3(
            posicaoAleatoria.x,
            0f,
            posicaoAleatoria.y
        );
    }
}