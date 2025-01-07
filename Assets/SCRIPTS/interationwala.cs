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
    private bool isPressed = false;
    private HashSet<GameObject> interactedObjects = new HashSet<GameObject>(); // Tracks interacted objects

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isPressed) 
        {
            isPressed = true; // Prevent further interactions while processing
            
            Ray r = new Ray(InteractorSource.position, InteractorSource.forward); 

            if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange)) 
            {
                GameObject targetObject = hitInfo.collider.gameObject;

                if (targetObject.TryGetComponent(out IInteractable interactObj)) 
                {
                    // Check if the object has already been interacted with
                    if (!interactedObjects.Contains(targetObject))
                    {
                        interactObj.Interact(); 
                        totalFillAmount += interactObj.GetFillAmount();
                        totalFillAmount = Mathf.Clamp(totalFillAmount, 0f, 1f);
                        imagepic.fillAmount = totalFillAmount;

                        // Add the object to the interacted list
                        interactedObjects.Add(targetObject);
                    }
                }
            }
        }

        // Reset the flag when the key is released
        if (Input.GetKeyUp(KeyCode.E))
        {
            isPressed = false;
        }
    }
}
