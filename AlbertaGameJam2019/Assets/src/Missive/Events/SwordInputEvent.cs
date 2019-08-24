using System.Collections;
using System.Collections.Generic;
using Missive_CSharp;
using UnityEngine;

public class SwordInputEvent : Missive
{
    public override string ToString()
    {
        throw new System.NotImplementedException();
        MissiveAggregator.instance.Publish(new SwordInputEvent());
    }
}
