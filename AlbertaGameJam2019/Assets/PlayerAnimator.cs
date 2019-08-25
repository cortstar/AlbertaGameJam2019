using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;

    private NavMeshAgent playerAgent;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponentSafely<Animator>();
        playerAgent = gameObject.GetComponentInParent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(playerAgent.velocity.magnitude);
        animator.SetBool("IsMoving", playerAgent.velocity.magnitude > 0f );
    }
}
