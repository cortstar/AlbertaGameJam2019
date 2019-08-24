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

        //Rotate Character
        Vector3 PlayerDirection = Vector3.right * Input.GetAxis("RHorizontal") + Vector3.forward * -Input.GetAxis("RVertical");
        if (PlayerDirection.sqrMagnitude > 0.0f)
        {
            transform.LookAt(transform.position + PlayerDirection);
        }
    }

    public void HandleMissive(SwordInputEvent missive)
    {
        gameObject.GetComponentSafely<SwordSkill>().Use(gameObject);
    }
}
