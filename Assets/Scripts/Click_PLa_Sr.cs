using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_PLa_Sr : MonoBehaviour
{
    public int NumPrenda_Pla_Sr;
    public Val_Pla_Sr Silla_Ele;
    public BoxCollider2D Bc;

    public void OnMouseDown()
    {
        Silla_Ele.NumPrenda = NumPrenda_Pla_Sr ;
        Bc.enabled = !Bc.enabled;

    }
}
