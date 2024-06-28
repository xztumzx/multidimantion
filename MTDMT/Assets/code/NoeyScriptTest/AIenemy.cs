using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIenemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ChangeDestination", 1f, 1f);
    }

    void ChangeDestination()
    {
        agent.SetDestination(target.transform.position);
    }

}
