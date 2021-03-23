using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrastrar : MonoBehaviour
{

    float x;
    float y;
    float z;
    Vector3 desp = new Vector3();

    void Awake()
    {
        //Obtener la posicion en el eje z del GameObject
        z = Camera.main.WorldToScreenPoint(new Vector3(0, 0, transform.position.z)).z;
    }


    void Update()
    {
        //Obtener la posicion del mouse
        x = Input.mousePosition.x;
        y = Input.mousePosition.y;

    }

    void OnMouseDown()
    {
        //Calcular el desplazamiento del mouse respecto al centro del objeto
        desp = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f)); ;
    }

    void OnMouseDrag()
    {
        //Mover el objeto en funcion de la posicion del mouse (sin variar el eje z), sumando el desplazamiento inicial
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(x, y, z)) + desp;
    }
    private void OnTriggerEnter2D(Collider2D collision)// Centrar los objetos en el objeto de validar
    {
        if (collision.gameObject.CompareTag("Validar"))
        {
            this.gameObject.transform.position = collision.gameObject.transform.position;

        }
    }
}
