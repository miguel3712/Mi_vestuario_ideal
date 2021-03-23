using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Validar2 : MonoBehaviour
{
    public int NumPrenda;
    public Almacenar2 Alm;

    public void OnMouseDown()
    {
        Alm.Prendas = NumPrenda;
        Alm.Permisos();
        Alm.Activar = true;

    }
}
