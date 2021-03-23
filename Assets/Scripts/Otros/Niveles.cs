using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Niveles : MonoBehaviour
{
    public GameManager Manager;
    public GameObject P1;
    public GameObject P2;
    public Transform posi;
    public bool pj;

    void Update()
    {
        if (Manager == null)
        {
            Manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }

        if (pj == false)
        {
            if (Manager.PLayer == 1)
            {
                Instantiate(P1, posi);
            }
            else
            {
                Instantiate(P2, posi);
            }

            pj = true;
        }
    }
}
