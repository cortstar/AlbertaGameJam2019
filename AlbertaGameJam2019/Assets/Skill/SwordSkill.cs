using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSkill : PlayerSkill
{
    public override Timer Cooldown { get; set; }
    protected override void Behave(GameObject User)
    {
        throw new System.NotImplementedException();
    }
}
