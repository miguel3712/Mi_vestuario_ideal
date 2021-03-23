using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Ele_Sra : MonoBehaviour
{
    public int NumPrenda_Ele_Sra;
    public Val_Ele_Sra Silla_Ele_Sra;
    public BoxCollider2D Bc;

    public void OnMouseDown()
    {
        Silla_Ele_Sra.NumPrenda = NumPrenda_Ele_Sra;
        Bc.enabled = !Bc.enabled;

    }
}
