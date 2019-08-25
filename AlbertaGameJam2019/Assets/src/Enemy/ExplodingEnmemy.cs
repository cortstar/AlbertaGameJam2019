using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingEnmemy : EnemyController
{
    public Vector3 playerPos;
    public Vector3 selfPos;
    public float distance;
    public float explosionRadius;

    [SerializeField]
    private float ExplosionTelegraphTime;
    [SerializeField]
    private Timer ExplosionTelegraphTimer;

    public bool exploding;
    void Awake()
    {
        ExplosionTelegraphTimer = new Timer(ExplosionTelegraphTime);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (exploding)
        {
            agent.velocity = Vector3.zero;
            ExplosionTelegraphTimer.Update();
            
            if (ExplosionTelegraphTimer.IsComplete)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            agent.SetDestination(player.transform.position);
            if (closeToPlayer())
            {
                exploding = true;
                agent.speed = 0;
            }
        }
    }

    bool closeToPlayer()
    {
        playerPos = player.transform.position;
        selfPos = transform.position;
        float xDist = Mathf.Abs(playerPos[0] - selfPos[0]);
        float yDist = Mathf.Abs(playerPos[2] - selfPos[2]);
        float hypoteneuse = Mathf.Sqrt(xDist * xDist) + (yDist * yDist);
        return hypoteneuse < distance;
    }

    private void OnDestroy()
    {
        playerPos = player.transform.position;
        selfPos = transform.position;
        float xDist = Mathf.Abs(playerPos[0] - selfPos[0]);
        float yDist = Mathf.Abs(playerPos[2] - selfPos[2]);
        float hypoteneuse = Mathf.Sqrt(xDist * xDist) + (yDist * yDist);
        if (hypoteneuse < explosionRadius)
        {
            player.GetComponent<PlayerHealthManager>().takeDamage(20);
        }
    }
}
