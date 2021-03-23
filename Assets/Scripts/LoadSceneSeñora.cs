using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneSeñora : MonoBehaviour
{
    public void LoadRandomScene1()
    {
        int index = Random.Range(5, 8);
        SceneManager.LoadScene(index);


    }
}
