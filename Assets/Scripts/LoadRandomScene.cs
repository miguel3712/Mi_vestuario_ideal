using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRandomScene : MonoBehaviour
{
    public void LoadRandomScene1()
    {
        int index = Random.Range(1,4);
        SceneManager.LoadScene(index);
        

    }
}
