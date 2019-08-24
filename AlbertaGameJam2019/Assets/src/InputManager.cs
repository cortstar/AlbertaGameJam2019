﻿using System.Collections;
using System.Collections.Generic;
using Missive_CSharp;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("A"))
        {
           Debug.Log("A was pressed");
        }
        if (Input.GetButtonDown("B"))
            Debug.Log("B was pressed");

        if (Input.GetButtonDown("X"))
            Debug.Log("X was pressed");

        if (Input.GetButtonDown("Y"))
            Debug.Log("Y was pressed");

        if (Input.GetAxis("RightTrigger") > 0)
            MissiveAggregator.instance.Publish(new SwordInputEvent());

        if (Input.GetAxis("LeftTrigger") > 0)
            Debug.Log("LeftTrigger");
    }
}
