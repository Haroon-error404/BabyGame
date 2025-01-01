using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthhealth : MonoBehaviour
{
    private float maxhealth = 100;
    private float currenthealth;
    [SerializeField]private Image healthBarfill;
    void Start()
    {
        currenthealth = maxhealth;
    }

    public void UpdateHealth(float amount){
        currenthealth += amount;
        UpdateHealthBar();
    }
    private void UpdateHealthBar(){
        float targetFillAmount = currenthealth / maxhealth;
        healthBarfill.fillAmount = targetFillAmount;
    }
}
