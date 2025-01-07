using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LOOSEWALESCRIPT : MonoBehaviour
{
    public void looseplayagain(){
        SceneManager.LoadScene("level 3");
    }
    public void looseplayagain2(){
        SceneManager.LoadScene("level4");
    }
    public void looseplayagain3(){
        SceneManager.LoadScene("level5");
    }

    
    public void loosequitgame(){
        Application.Quit();
    }
}
