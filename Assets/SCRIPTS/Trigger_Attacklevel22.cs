using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger_Attack22 : MonoBehaviour
{
    public Rigidbody TRIGERONLOOK;
    public void OnTriggerEnter(Collider TRIGERONLOOK) {
        SceneManager.LoadScene("losScreen2");
    }
}
