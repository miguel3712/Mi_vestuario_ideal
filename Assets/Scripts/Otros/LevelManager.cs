using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    int i = 1;
    public GameObject[] Pantalones;
    public GameObject[] Camisas;
    public GameObject[] Camisetas;


    private void Start()
    {
        MostrarCuadrados();
    }
    

    
    public void MostrarCuadrados()
    {

        //Muestra nada mas los pantalones
        for (int i = 0; i < Camisas.Length; i++)
        {
            Camisas[i].GetComponentInChildren<SpriteRenderer>().enabled = false;
            Pantalones[i].GetComponentInChildren<SpriteRenderer>().enabled = true;
            Camisetas[i].GetComponentInChildren<SpriteRenderer>().enabled = false;


        }
    }
    public void MostrarCirculos()
    {

        //Muestra nada mas las camisas
        for (int i = 0; i < Camisas.Length; i++)
        {
            Camisas[i].GetComponentInChildren<SpriteRenderer>().enabled = true;
            Pantalones[i].GetComponentInChildren<SpriteRenderer>().enabled = false;
            Camisetas[i].GetComponentInChildren<SpriteRenderer>().enabled = false;


        }
    }

    public void Mostrartriangulos()
    {

        //Muestra nada mas las camisas
        for (int i = 0; i < Camisetas.Length; i++)
        {
            Camisas[i].GetComponentInChildren<SpriteRenderer>().enabled = false;
            Pantalones[i].GetComponentInChildren<SpriteRenderer>().enabled = false;
            Camisetas[i].GetComponentInChildren<SpriteRenderer>().enabled = true;


        }
    }



}