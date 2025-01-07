using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenuoption : MonoBehaviour
{

    public void levelselect(){
        SceneManager.LoadScene("level_select");
    }

    public void quit(){
        Application.Quit();
    }
    
}
