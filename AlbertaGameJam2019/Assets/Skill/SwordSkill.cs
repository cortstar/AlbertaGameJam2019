using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class SwordSkill : PlayerSkill
{
    [FormerlySerializedAs("SwordObject")] [SerializeField]
    private GameObject swordObject;

    private Timer _cooldown = new Timer(.2f);
    public override Timer Cooldown
    {
        get => _cooldown;
        set => _cooldown = value;
    }

    protected override void Behave(GameObject user)
    {
        Instantiate(swordObject, transform.position + 1f * gameObject.transform.up, transform.rotation);
    }

    protected override void OnUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("j");
            Use(gameObject);
        }
    }
}
