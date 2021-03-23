using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Manager : MonoBehaviour
{
    public Sprite[] Prendas;
    public SpriteRenderer[] Prendas_Cama;
    
    void Start()
    {
        for (int i = 0; i < Prendas_Cama.Length; i++)
        {
            Prendas_Cama[i].sprite = ObtenerSprite(i);
        }
    }
    public Sprite ObtenerSprite(int pos)
    {
        for (int i = 0; i < Prendas.Length; i++)
        {
            if (Prendas[i].name.Equals(PlayerPrefs.GetString("Prenda"+pos)))
            {
                return Prendas[i];
            }
        }
        return null;
    }    

    
    void Update()
    {
        
    }
}
