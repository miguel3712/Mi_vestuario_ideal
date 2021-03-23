using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class comprobacion : MonoBehaviour
{
    public new_orden_llegada[] prendas_comrpobar;

    public int nivel;
    public int contador;
    public string nombre;
    bool iniciar;
   


    // Update is called once per frame
    void Update()
    {
        if (iniciar)
        {
            for (int i = 0; i < prendas_comrpobar.Length; i++)
            {
                if (prendas_comrpobar[i].prenda_correcta)
                {
                    contador++;
                }
            }
            if (contador == nivel)
            {
               
                SceneManager.LoadScene(nombre);
                
                Debug.Log("siguiente nivel");
            }
            if (contador != nivel)
            {
               
                Debug.Log("NOOO siguiente nivel");
            }
            iniciar = false;
        }        
    }

    public void verificar()
    {
        iniciar = true;
    }


}
