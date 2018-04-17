using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public GameObject projetilPrefab;

    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) ||
            GvrControllerInput.ClickButtonDown ||
            OVRInput.Get(OVRInput.Button.One))
        {
            Atirar();
        }
    }

    private void Atirar()
    {
        GameObject projetil = Instantiate(projetilPrefab);
        projetil.transform.position = Camera.main.transform.position;
        projetil.transform.forward = Camera.main.transform.forward;
    }
}