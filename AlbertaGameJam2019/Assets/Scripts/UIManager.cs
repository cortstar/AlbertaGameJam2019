using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Slider healthBar;
    public Text healthText;
    public static UIManager instance;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //healthBar.maxValue = pStats.maxHealth;
        //healthBar.value = pStats.health;
        //healthText.text = "HP: " + pStats.health + "/" + pStats.maxHealth;
    }
}
