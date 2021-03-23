using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Val_Pla_Sr : MonoBehaviour
{
    public int NumPrenda;
    public Alm_Pla_Sr Alm;

    public void OnMouseDown()
    {
        Alm.Prendas = NumPrenda;
        Alm.Permisos();
        Alm.Activar = true;

    }
}
