using System;
using System.Collections;
using System.Collections.Generic;
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
        Debug.Log(damageCooldown.RemainingTime);

    }

    private void OnCollisionStay(Collision other)
    {
        var playerHealth = other.gameObject.GetComponent<PlayerHealthManager>();
        Debug.Log(damageCooldown.IsComplete);
        if (damageCooldown.IsComplete && playerHealth!=null)
        {
            Debug.Log("called");
            playerHealth.takeDamage(damage);
            damageCooldown.Reset();
            damageCooldown.Unpause();
        }
    }
}
