using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WINWALESCRIPT : MonoBehaviour
{
    public void nextlevel(){
        SceneManager.LoadScene("level4");
    }
    public void nextlevel1(){
        SceneManager.LoadScene("level5");
    }
    

    
    public void nextquitgame(){
        Application.Quit();
    }
}

