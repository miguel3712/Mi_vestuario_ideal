using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_orden_llegada : MonoBehaviour
{
    [Header("Nombre de la prenda correcta")]
    public string nombre_prenda;
    public bool prenda_correcta;
    public bool preparado;

    [Header("prendas")]
    public Click[] prenda_;
    public Click prenda_escogida;

    public bool hay_prenda;
    bool activa_collider;
    
    bool devolver_prenda;
    public Animator Ropa;
  

    /* Este script es para comrpobar si la prenda colocada es correcta o no.
    */

    private void Update()
    {
        if (activa_collider && !hay_prenda)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
            activa_collider = false;
        }

        //cuando no hay ninguna prenda, los valores son restablesidos.
        if (prenda_escogida != null)
        {
            if (prenda_escogida.inicio)
            {
                hay_prenda = false;
                activa_collider = true;
                prenda_correcta = false;

                prenda_escogida = null;
            }
        }


        //reconoce cual prenda esta en posicion intermedio.
        //y al dar click en el numero, mueve esta prenda a su posicion.
        if (preparado)
        {
            for (int i = 0; i < prenda_.Length; i++)
            {
                if (prenda_[i].intermedio)
                {
                    prenda_[i].pos_destino.position = transform.position;
                    prenda_[i].final = true;
                    preparado = false;
                }
            }
        }

    }

    //detecta la prenda que entra al collider,  la compara con la variable nombre prenda
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(nombre_prenda))
        {
            prenda_correcta = true;
        }

        if (collision.gameObject.GetComponent<Click>())
        {
            hay_prenda = true;
            prenda_escogida = collision.gameObject.GetComponent<Click>();
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
        if (collision.gameObject.CompareTag(nombre_prenda))
        {
            Ropa.SetBool("camisa", true);
            
        }
    }
    


    private void OnMouseDown()
    {
      preparado = !preparado;
    }
  
}
