 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSilla : MonoBehaviour
{
    public int NumPrenda;
    public  Validar Silla;
    public BoxCollider2D Bc;
    
    public void OnMouseDown()
    {
        Silla.NumPrenda = NumPrenda;
        Bc.enabled = !Bc.enabled;

    }
    
    

}
