using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class maidnavigationmovement : MonoBehaviour
{
    public float moveRange = 10f; 
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        SetRandomDestination(); 
    }

    void Update()
    {
        
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            SetRandomDestination(); 
        }
    }

    void SetRandomDestination()
    {
        
        Vector3 randomDirection = Random.insideUnitSphere * moveRange;
        randomDirection += transform.position;

        
        NavMeshHit hit;
        if (NavMesh.SamplePosition(randomDirection, out hit, moveRange, NavMesh.AllAreas))
        {
            agent.SetDestination(hit.position); 
        }
    }
}
