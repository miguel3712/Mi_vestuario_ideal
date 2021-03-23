using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class devolverPrenda : MonoBehaviour
{
    public bool devolver;

    public Click[] prendas;


    /*detecta el click en la escena, para devolver la prenda en posicion intermedia,
     * a su inicio     
    */
    void Update()
    {
        if (devolver)
        {
            for (int i = 0; i < prendas.Length; i++)
            {
                if (prendas[i].intermedio)
                {
                    prendas[i].intermedio = false;
                    prendas[i].inicio = true;
                }
            }
            devolver = false;
        }

    }

    private void OnMouseDown()
    {
        if (gameObject.CompareTag("background"))
        {
            devolver = true;
        }
    }

    
}
