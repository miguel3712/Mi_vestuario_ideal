using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class recargar : MonoBehaviour
{
    public string nombreDeEscena;
  

    public void re()
    {
        SceneManager.LoadScene(nombreDeEscena);
    }
}
