using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class SwordSkill : PlayerSkill
{
    [FormerlySerializedAs("SwordObject")] [SerializeField]
    private GameObject swordObject;

    [SerializeField] private float distance;

    private Timer _cooldown = new Timer(.2f);
    public override Timer Cooldown
    {
        get => _cooldown;
        set => _cooldown = value;
    }

    protected override void Behave(GameObject user)
    {
        Instantiate(swordObject, transform.position +  distance * gameObject.transform.up, transform.rotation);
    }
    
}
