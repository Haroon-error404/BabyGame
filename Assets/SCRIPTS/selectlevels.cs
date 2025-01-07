using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectlevels : MonoBehaviour
{
    public void level1(){
        SceneManager.LoadScene("level 3");
    }

    public void level2(){
        SceneManager.LoadScene("level 4");
    }
    public void level3(){
        SceneManager.LoadScene("level 5");
    }
}

