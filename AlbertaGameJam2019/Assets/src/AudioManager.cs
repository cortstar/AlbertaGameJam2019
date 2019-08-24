using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource Sword;
    public AudioSource Gun;
    public AudioSource Footstep;
    public AudioSource EnemyDeath;
    public AudioSource EnemyAttack;
    public AudioSource Explosion;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void swordSound(Vector3 coords)
    {
        Sword.transform.position = coords;
        Sword.Play();
    }

    void gunSound(Vector3 coords)
    {
        Gun.transform.position = coords;
        Gun.Play();
    }
    
    void footstepSound(Vector3 coords)
    {
        Footstep.transform.position = coords;
        Footstep.Play();
    }
    
    void enemyDeathSound(Vector3 coords)
    {
        EnemyDeath.transform.position = coords;
        EnemyDeath.Play();
    }
    
    void enemyAttackSound(Vector3 coords)
    {
        EnemyAttack.transform.position = coords;
        EnemyAttack.Play();
    }
    
    void explosionSound(Vector3 coords)
    {
        Explosion.transform.position = coords;
        Explosion.Play();
    }
}