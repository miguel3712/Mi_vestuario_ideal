using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class timermemoria : MonoBehaviour
{
    public float tiempo = 10f;
    

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;
        if (tiempo <= 0)
        {

            Time.timeScale = 0;
        }
    }
}
