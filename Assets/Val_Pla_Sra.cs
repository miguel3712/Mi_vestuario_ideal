using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Val_Pla_Sra : MonoBehaviour
{
    public int NumPrenda;
    public Alm_Pla_Sra Alm;

    public void OnMouseDown()
    {
        Alm.Prendas = NumPrenda;
        Alm.Permisos();
        Alm.Activar = true;

    }
}
