using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Manager;

    public int PLayer;
    // Start is called before the first frame update
    private void Awake()
    {
        if (Manager == null)
        {
            Manager = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else if (Manager != this)
        {
            Destroy(gameObject);
        }

    }
}
