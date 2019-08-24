using System.Collections;
using System.Collections.Generic;
using Missive_CSharp;
using UnityEngine;
using UnityEngine.AI;


public class PlayerController : MonoBehaviour, IMissiveListener<SwordInputEvent>
{
    public string startPoint;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandleMissive(SwordInputEvent missive)
    {
        gameObject.GetComponentSafely<SwordSkill>().Use(gameObject);
    }
}
