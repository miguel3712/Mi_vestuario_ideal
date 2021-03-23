using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Silla_Ele_Sr : MonoBehaviour
{
    public int NumPrenda_Ele_Sr;
    public Validar_Ele_Sr Silla_Ele;
    public BoxCollider2D Bc;

    public void OnMouseDown()
    {
        Silla_Ele.NumPrenda = NumPrenda_Ele_Sr;
        Bc.enabled = !Bc.enabled;

    }
}
    