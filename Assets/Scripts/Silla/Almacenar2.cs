using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Almacenar2 : MonoBehaviour
{
    public int Contador;
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;

    public GameObject Validar;
    public int Prendas;
    private bool Orden = true;//Si el orden esta bien o mal.
    public bool Activar = false;
    // Start is called before the first frame update
    void Start()
    {
        Contador = 1;
    }

    // Update is called once per frame
    void Update()
    {
        while (Contador <= 4 && Activar == true)
        {

            if (Prendas == Contador && Orden == true)
            {

                Orden = true;
                Debug.Log("1");

            }
            else
            {
                Orden = false;
                Debug.Log("0");
            }
            Activar = false;

            Contador++;

        }
        if (Contador == 5 && Orden == true)
        {
            Debug.Log("El orden es correcto");

            SceneManager.LoadScene("Victoria_Señora");
        }
        else if (Contador == 5 && Orden == false)
        {
            Debug.Log("El orden es incorrecto");


            SceneManager.LoadScene("Perdida_Señora");
        }


    }
    public void Permisos()
    {
        switch (Prendas)
        {

            case 4://Prenda 4
                P4.transform.position = Validar.transform.position;
                break;
            case 3://Prenda 3
                P3.transform.position = Validar.transform.position;
                break;
            case 2://Prenda 2
                P2.transform.position = Validar.transform.position;
                break;
            case 1://Prenda 1
                P1.transform.position = Validar.transform.position;
                break;
        }

    }
}
