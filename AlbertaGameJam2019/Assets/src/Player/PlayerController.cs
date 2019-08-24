using System.Collections;
using System.Collections.Generic;
using Missive_CSharp;
using UnityEngine;
using UnityEngine.AI;


public class PlayerController : MonoBehaviour, IMissiveListener<SwordInputEvent>
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = target.position;
    }

    public void HandleMissive(SwordInputEvent missive)
    {
        gameObject.GetComponentSafely<SwordSkill>().Use(gameObject);
    }
}
