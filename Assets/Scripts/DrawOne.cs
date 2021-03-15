using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawOne : MonoBehaviour
{
  



 

    // Start is called before the first frame update
    void Start()
    {
       
        Debug.Log("Olá! Pede uma carta.");
        Debug.Log("Pressiona a tecla Espaço para pedir uma carta.");

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            string[] naipe = new string[] { "Ouros", "Espadas", "Copas", "Paus" }; // declara o naipe da carta
            string naipeRandom = naipe[Random.Range(0, naipe.Length)];

            string[] figura = new string[] { "Ás", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "Valete", "Rainha", "Rei" }; // declara o número ou figura da carta
            string figuraRandom = figura[Random.Range(0, figura.Length)];

            Debug.Log("Saiu a carta " + figuraRandom + " de " + naipeRandom + ".");


        }
    }
}
