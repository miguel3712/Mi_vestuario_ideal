using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSilla2 : MonoBehaviour
{
    public int NumPrenda2;
    public Validar2 Silla2;
    public BoxCollider2D Bc2;
    public void OnMouseDown()
    {
        Silla2.NumPrenda = NumPrenda2;
        Bc2.enabled = !Bc2.enabled;
    }
}
