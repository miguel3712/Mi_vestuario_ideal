using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Validar_Ele_Sr : MonoBehaviour
{
    public int NumPrenda;
    public Almacenar_Elegante Alm;

    public void OnMouseDown()
    {
        Alm.Prendas = NumPrenda;
        Alm.Permisos();
        Alm.Activar = true;

    }
}
