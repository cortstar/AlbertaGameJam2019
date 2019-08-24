using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    protected NavMeshAgent agent;
    protected EnemyHealthManager health;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponentSafely<NavMeshAgent>();
        health = gameObject.GetComponentSafely<EnemyHealthManager>();
    }
    
}
