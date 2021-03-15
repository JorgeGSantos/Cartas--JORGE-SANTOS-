using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogoCartas : MonoBehaviour
{
    string txtnaipe;
    int naipe;
    int figura;

    void Start()
    {
        Debug.Log("Retira uma carta do baralho");
        Debug.Log("Carrega no ESPAÇO para retirar uma carta");

    }

    void Update()
    {

        naipe = Random.Range(1, 5);
        figura = Random.Range(1, 14);

        if (naipe == 1) txtnaipe = "Copas";
        else if (naipe == 2) txtnaipe = "Espadas";
        else if (naipe == 3) txtnaipe = "Ouros";
        else if (naipe == 4) txtnaipe = "Paus";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (figura == 1) Debug.Log("A carta é o Ás de " + txtnaipe);
            else if (figura == 11) Debug.Log("A carta é a Dama de " + txtnaipe);
            else if (figura == 12) Debug.Log("A carta é o Valete de " + txtnaipe);
            else if (figura == 13) Debug.Log("A carta é o Ás de " + txtnaipe);

            else Debug.Log("A carta é o " + figura + " de " + txtnaipe);
        }
    }
}