using UnityEngine;

public class RandomWork : MonoBehaviour, IInteractable
{
    public GameObject trashbin;       
    public GameObject trashMiddle;    

    public float randomss = 60f;      
    public float sida;
    public float sidewala;
    public float leftwala;

    public float fillAmount = 0.6f; 

    private bool hasInteracted = false; 

    public void Interact()
    {
        if (hasInteracted)
        {
            return; 
        }

        hasInteracted = true; 

        
        trashbin.transform.Rotate(randomss, 0, 0);

       
        transform.position = new Vector3(leftwala, sida, sidewala);

        
        if (trashMiddle != null)
        {
            trashMiddle.SetActive(true);
        }
    }

    public float GetFillAmount()
    {
        return fillAmount;  
    }
}
