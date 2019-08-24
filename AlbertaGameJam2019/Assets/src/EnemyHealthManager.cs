﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public int totalHealth;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = totalHealth;
    }

    // Update is called once per frame
    void Update()
    {
        WorldUIManager.instance.maxHealth = totalHealth;
        WorldUIManager.instance.currentHealth = currentHealth;
    }

    public void takeDamage(int damage)
    {
        currentHealth += -damage;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
