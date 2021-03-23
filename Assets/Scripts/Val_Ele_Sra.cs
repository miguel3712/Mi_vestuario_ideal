using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Val_Ele_Sra : MonoBehaviour
{
    public int NumPrenda;
    public Alm_Ele_Sra Alm;

    public void OnMouseDown()
    {
        Alm.Prendas = NumPrenda;
        Alm.Permisos();
        Alm.Activar = true;

    }
}
