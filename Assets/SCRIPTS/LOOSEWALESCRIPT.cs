using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LOOSEWALESCRIPT : MonoBehaviour
{
    public void looseplayagain(){
        SceneManager.LoadScene("level3");
    }

    
    public void loosequitgame(){
        Application.Quit();
    }
}
