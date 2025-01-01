using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactionwala : MonoBehaviour
{
    public Transform InteractorSource;  
    public float InteractRange = 3f;    
    public Image imagepic;              

    private float totalFillAmount = 0f; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            Ray r = new Ray(InteractorSource.position, InteractorSource.forward); 

            if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange)) 
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj)) 
                {
                    interactObj.Interact(); 
                    totalFillAmount += interactObj.GetFillAmount();
                    totalFillAmount = Mathf.Clamp(totalFillAmount, 0f, 1f);
                    imagepic.fillAmount = totalFillAmount;
                }
            }
        }
    }
}
