using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;
    
    private 
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponentSafely<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
