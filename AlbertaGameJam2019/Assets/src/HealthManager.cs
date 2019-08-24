using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int totalHealth;
    public int currentHealth;
    public bool isPlayer;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = totalHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer)
        {
            UIManager.instance.maxHealth = totalHealth;
            UIManager.instance.currentHealth = currentHealth;
            WorldUIManager.instance.maxHealth = totalHealth;
            WorldUIManager.instance.currentHealth = currentHealth;
        }   
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
