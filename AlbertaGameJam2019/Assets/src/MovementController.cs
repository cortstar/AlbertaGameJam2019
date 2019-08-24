﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovementController : MonoBehaviour
{
    public float speed = 6.0f;
    public static MovementController instance;
    private Vector3 moveDirection = Vector3.zero;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponentSafely<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move Character
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        moveDirection *= speed;
        agent.Move(moveDirection*Time.deltaTime);
    }
}