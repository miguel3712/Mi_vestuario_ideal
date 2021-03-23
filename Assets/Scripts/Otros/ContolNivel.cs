using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContolNivel : MonoBehaviour
{
    public GameManager Manager;


    void Start()
    {
        if (Manager == null)
        {
            Manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }
    }

    public void Personaje(int PJ)
    {
        Manager.PLayer = PJ;
    }
}
