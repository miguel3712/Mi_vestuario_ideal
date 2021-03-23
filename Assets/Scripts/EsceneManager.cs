using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsceneManager : MonoBehaviour
{
    public AudioSource sonido;
    void Start()
    {
        sonido.volume = PlayerPrefs.GetFloat("Volumen");
    }
}
