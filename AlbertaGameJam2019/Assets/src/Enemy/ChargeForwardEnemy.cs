﻿using Missive_CSharp;
using UnityEngine;

public class ChargeForwardEnemy : EnemyController
{
    private Timer damageCooldown;

    [SerializeField]
    private float damageCooldownTime;

    [SerializeField] private int damage;

    void Awake()
    {
        damageCooldown = new Timer(damageCooldownTime);
    }
    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
        damageCooldown.Update();
    }

    private void OnCollisionStay(Collision other)
    {
        var playerHealth = other.gameObject.GetComponent<PlayerHealthManager>();
        
        if (damageCooldown.IsComplete && playerHealth!=null)
        {
            playerHealth.takeDamage(damage);
            damageCooldown.Reset();
            damageCooldown.Unpause();
            MissiveAggregator.instance.Publish(new EnemyAttackEvent(transform.position));
        }
    }
}
