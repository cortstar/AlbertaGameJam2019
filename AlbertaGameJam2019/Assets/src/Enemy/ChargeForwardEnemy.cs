using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeForwardEnemy : EnemyController
{
    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
    }
}
