using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthManager : MonoBehaviour
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
        UIManager.instance.maxHealth = totalHealth;
        UIManager.instance.currentHealth = currentHealth;
    }

    public void takeDamage(int damage)
    {
        currentHealth += -damage;
        if (currentHealth <= 0)
        {
            Invoke("GoToMain", 1);
        }
    }

    private void GoToMain()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
