using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WINWALESCRIPT : MonoBehaviour
{
    public void nextlevel(){
        SceneManager.LoadScene("main");
    }

    
    public void nextquitgame(){
        Application.Quit();
    }
}

