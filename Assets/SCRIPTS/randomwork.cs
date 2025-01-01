using UnityEngine;

public class RandomWork : MonoBehaviour, IInteractable
{
    public GameObject trashbin;       
    public float randomss = 60f;      
    public float sida;
    public float sidewala;
    public float leftwala;

    public float fillAmount = 0.6f; 
    public void Interact()
    {
        
        trashbin.transform.Rotate(randomss, 0, 0);

        transform.position = new Vector3(leftwala, sida, sidewala);
    }

    
    public float GetFillAmount()
    {
        return fillAmount;  
    }
} 