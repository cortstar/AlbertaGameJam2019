using System.Collections;
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
        timeToLive.RegisterTimerCallback( () => Destroy(this) );
    }
    // Update is called once per frame
    void Update()
    {
        timeToLive.Update();
    }
}
