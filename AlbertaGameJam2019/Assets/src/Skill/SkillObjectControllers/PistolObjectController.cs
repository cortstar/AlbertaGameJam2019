using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolObjectController : MonoBehaviour
{
    Timer timeToLive = new Timer(0.1f);
    
    void Start()
    {
        timeToLive.RegisterTimerCallback(()=>Destroy(this.gameObject));   
    }

    private void Update()
    {
        timeToLive.Update();
    }
}
