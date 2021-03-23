using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Pla_Sra : MonoBehaviour
{
    public int NumPrenda_Pla_Sra;
    public Val_Pla_Sra Silla_Pla_Sra;
    public BoxCollider2D Bc;

    public void OnMouseDown()
    {
        Silla_Pla_Sra.NumPrenda = NumPrenda_Pla_Sra;
        Bc.enabled = !Bc.enabled;

    }
}
