﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordObjectController : MonoBehaviour
{
    [SerializeField]
    private float timeActive;

    private Timer timeToLive;

    void Start()
    {
        timeToLive = new Timer(timeActive);
        timeToLive.RegisterTimerCallback( () => Destroy(gameObject) );
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(timeToLive);
        timeToLive.Update();
    }
}
