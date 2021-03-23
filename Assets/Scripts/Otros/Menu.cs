using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
                
    public void CambiarEscena(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
    public void CerrarJuego()
    {
        Application.Quit();
        Debug.Log("Salir");
    }

    public void PausarJuego()
    {
        if (Time.timeScale > 0)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
            Debug.Log(Time.timeScale);
        }
    }
    public void PausarMusica(AudioSource audios)
    {
        if (audios.volume == 1)
        {
            audios.volume = 0;
        }
        else
        {
            audios.volume = 1;
        }

        PlayerPrefs.SetFloat("Volumen",audios.volume);       
    }

}
