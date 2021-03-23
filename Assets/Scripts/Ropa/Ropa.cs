using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]


public class Ropa : MonoBehaviour
{
    public string nombre;
    public Sprite ImagenInicial;
    public Sprite ImnagenIntermedia;
    public Sprite ImagenDestino;
    public Transform posicionEnColgador;
    public Transform posicionEnMostrador;
    public Transform posicionExtendida;
    public bool esCorrecta;

    public void Start()
    {
        
    }

}
