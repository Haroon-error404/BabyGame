using UnityEngine;

public class RandomWork1 : MonoBehaviour, IInteractable
{
    public GameObject trashbin;       
    public float randomss = 60f;      
    public float sida;
    public float sidewala;
    public float leftwala;

    public float fillAmount = 0.6f; 

    public void Interact()
    {
        // Ensure the trashbin has a Rigidbody for natural physics
        Rigidbody rb = trashbin.GetComponent<Rigidbody>();
        if (rb == null)
        {
            rb = trashbin.AddComponent<Rigidbody>(); // Add Rigidbody if it doesn't exist
        }

        // Apply a torque to make the object rotate naturally
        rb.AddTorque(new Vector3(randomss, Random.Range(-randomss, randomss), Random.Range(-randomss, randomss)), ForceMode.Impulse);

        // Optionally set a new position (if needed)
        trashbin.transform.position = new Vector3(leftwala, sida, sidewala);
    }

    public float GetFillAmount()
    {
        return fillAmount;  
    }
}
