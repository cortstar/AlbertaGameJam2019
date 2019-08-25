using System.Collections;
using System.Collections.Generic;
using Missive_CSharp;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAnimator : MonoBehaviour, IMissiveListener<SwordInputEvent>
{
    private Animator animator;

    private NavMeshAgent playerAgent;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponentSafely<Animator>();
        playerAgent = gameObject.GetComponentInParent<NavMeshAgent>();
        MissiveAggregator.instance.Register(this);
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("IsMoving", playerAgent.velocity.magnitude > 0f );
    }

    public void HandleMissive(SwordInputEvent missive)
    {
        animator.SetTrigger("SwordAttack");
        Debug.Log("handled");
    }
}
