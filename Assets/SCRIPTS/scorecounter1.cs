using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scorecounter1 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timertext;
    [SerializeField] float elapsedtime;
    public Image imagepic;

    void Update(){

        if(elapsedtime > 0){
            elapsedtime -= Time.deltaTime;
        }
        else if (elapsedtime < 0){
            elapsedtime = 0;
        }
         
         int minutes = Mathf.FloorToInt(elapsedtime / 60);
         int seconds = Mathf.FloorToInt(elapsedtime % 60);
         timertext.text = string.Format( "{0:00} : {1:00}" , minutes , seconds);

         if(imagepic.fillAmount == 1){
            SceneManager.LoadScene("winScreen1");
         }

         if(elapsedtime == 0){
            SceneManager.LoadScene("losScreen1");
         }
    }

}
