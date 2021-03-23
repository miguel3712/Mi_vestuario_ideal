using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    [Header("Posiciones")]
    public Transform pos_inicio;
    public Transform pos_intermedio;
    public Transform pos_destino;

    [Header("comprobacion")]
    public bool inicio;
    public bool intermedio;
    public bool final;

    public int count;

    public int numero_prenda;

    [Header("demas prendas")]
    public Click[] otras_prendas;
    bool mirar_otras_prendas;
    

    /* Este es el script que tendra cada prenda (sprite), con cada click consecutivo se movera en 3 posicones (inicio, intermedio, y final).
     * todas partiran en la posicion de INICIO. 
     * Al dar click sobre ella se movera al INTERMEDIO, para indicar su seleccion. 
     * Estando en esta posicion INTERMEDIO, se le da click a uno de los numeros, se movera a esta posicon, quedando seleccionada.
     * Para devolver la prenda al INICIO, estando en la posicion INTERMEDIO, se debe dar click en cualquier parte del escenario (BackGround).
     * Para devolver la prenda al INICIO, entando en la posicion final, se debe dar click en la prenda.
    */

    private void Start(){
        inicio = true;
 

    }



    void Update(){

        //dependiendo del numero count, que se sumara por los clicks dados, se movera en las posiciones de cada switch
        switch (count){
            case 0:
                transform.position = pos_inicio.position;
                break;
            case 1:
                transform.position = pos_intermedio.position;
                break;
            case 2:
                transform.position = pos_destino.position;
                intermedio = false;
                break;
        }


        if (inicio){
            count = 0;
        }

        if (intermedio){
            count = 1;
            
        }
        if (final){
            count = 2;
           
        }

        //devolvera esta prenda al Inicio, si se selecciona otra prenda. 
        if (mirar_otras_prendas)
        {
            for (int i = 0; i < otras_prendas.Length; i++)
            {
                if (otras_prendas[i].intermedio)
                {
                    otras_prendas[i].intermedio = false;
                    otras_prendas[i].inicio = true;
                }
            }
            mirar_otras_prendas = false;
        }

    }

    //los click dados movera cambiara la variable count, para mover las posiciones del switch
    void OnMouseDown() {
        if (inicio){
            intermedio = true;
            inicio = false;
            final = false;
        }
        if (final){
            inicio = true;
            final = false;
        }

        if (intermedio){
            mirar_otras_prendas = true;
        }
    }



    






}
