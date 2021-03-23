using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Validar : MonoBehaviour
{
    public int NumPrenda;
    public Almacenar Alm;
    
    public void OnMouseDown()
    {
        Alm.Prendas = NumPrenda;
        Alm.Permisos();
        Alm.Activar = true;

    }
    
}
