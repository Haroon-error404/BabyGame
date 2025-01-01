using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenuoption : MonoBehaviour
{
    public void playgame(){
        SceneManager.LoadScene("level3");
    }

    public void quit(){
        Application.Quit();
    }
}
