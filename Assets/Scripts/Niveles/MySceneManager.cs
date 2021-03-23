using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

/// <summary>
/// Esta clase se encarga de administrar todo el nivel
/// </summary>
public class MySceneManager : MonoBehaviour
{
    /// <summary>
    /// Objeto estatico de la misma clase para llamados de los demás objetos
    /// </summary>
    public static MySceneManager sceneManager;
    public PrendaController[] prendasMueble;
    public PrendaController[] prendasCama;
    public Sprite[] Correctas;
    public int difficulty;
    public GameObject Pasar_Nivel;
    public GameObject Reiniciar;
    public GameObject Mensaje;
    public AudioSource sonido;
    
    


    GameObject prendaSeleccionada;

    public GameObject PrendaSeleccionada
    {
        get { return prendaSeleccionada; }
        
        set { prendaSeleccionada = value; }

        
    }

    private void Awake()
    {
        sceneManager = this;
    }

    // Start is called before the first frame update
    void Start()
    {

        PlayerPrefs.SetInt("Difficulty", difficulty);
        sonido.volume = PlayerPrefs.GetFloat("Volumen");
        

          
        
    }
    public void Update()
    {
       
    }

    /// <summary>
    /// Este método se llama desde el Editor desde los objetos Prenda
    /// </summary>
    /// <param name="prenda">Recibe por parámetros un objeto de tipo PrendaController</param>
    public void PrendaActiva(PrendaController prenda)
    {
        prendaSeleccionada = prenda.gameObject;
            
        foreach (PrendaController p in prendasMueble)
        {
            if (!p.Equals(prenda))
                p.transform.localScale = Vector3.one; // new Vector3(1, 1, 1)
        }
    }
    
    /// <summary>
    /// Este método es llamado desde el editor por el objeto Background
    /// </summary>
    public void ResetPrendas()
    {
        foreach (PrendaController p in prendasMueble)
        {
            p.transform.localScale = Vector3.one; // new Vector3(1, 1, 1)
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public void ChangeClotch()
    {
        foreach (PrendaController p in prendasMueble)
        {
            p.ChangeSprite(); 
        }

    }
    public void Seleccionar()
    {
        bool endGame = true;

        foreach (PrendaController p in prendasCama)
        {
            if (p.GetComponent<Button>().interactable == true)
            {
                endGame = false;
                ResetPrendas();
                ChangeClotch();
                break;
            }
        }
        if (endGame)
        {
            ValidarPrendas();
            foreach (PrendaController p in prendasMueble)
                p.gameObject.SetActive(false);
        }
    }
    
    void ValidarPrendas()
    {
        bool correct = true;

        for (int i = 0; i < prendasCama.Length; i++)
        {
            Sprite sprite = prendasCama[i].GetComponent<Image>().sprite;
            if (!sprite.Equals(Correctas[i]))
            {
                prendasCama[i].Incorrecta.SetActive(true);
               
            }
            else
            {
                prendasCama[i].Correcta.SetActive(true);
            }
            if (!Correctas.Contains(sprite))
                correct = false;
        }
        for (int i = 0; i < prendasCama.Length; i++)
        {
            PlayerPrefs.SetString("Prenda" + i, prendasCama[i].GetComponent<Image>().sprite.name);
            Debug.Log(PlayerPrefs.GetString("Prenda" + i));

        }
        Debug.Log("Resultados: " + correct);

        

        if (correct == true)
        {
            Pasar_Nivel.SetActive(true);
        }
        else 
        {

            Reiniciar.SetActive(true);
        }
        
    }
  


}