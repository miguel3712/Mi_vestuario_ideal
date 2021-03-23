using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrendaController : MonoBehaviour
{
    public enum Posicion { Mueble, Cama }
    public Posicion position;
    public Sprite[] sprites;



    public GameObject Incorrecta;
    public GameObject Correcta;
    Image myImage;
    int spritePos;
    

        void Start()
    {
        myImage = GetComponent<Image>();
        spritePos = 0;

        if (position.Equals(Posicion.Mueble))
            ChangeSprite();
        
    }

   

    public void Click()
    {
        if (position.Equals(Posicion.Mueble))
        {
            transform.localScale = new Vector3(1.2f, 1.2f, 1f);
            MySceneManager.sceneManager.PrendaActiva(this);
        }
        else
        {
            if (position.Equals(Posicion.Cama))
            {
                myImage.sprite = MySceneManager.sceneManager.PrendaSeleccionada.GetComponent<Image>().sprite;
                myImage.color = Color.white;
                GetComponent<Button>().interactable = false;
                MySceneManager.sceneManager.Seleccionar();
            }
          
        }
    }

    public void ChangeSprite()
    {   if(spritePos < sprites.Length)
        {
            myImage.sprite = sprites[spritePos];
            spritePos++;
        }
       
    }
   
}