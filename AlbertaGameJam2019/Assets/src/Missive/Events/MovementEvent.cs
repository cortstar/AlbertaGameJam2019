using System.Collections;
using System.Collections.Generic;
using Missive_CSharp;
using UnityEngine;

public class MovementEvent : Missive
{
    public Vector2 axis;

    MovementEvent(Vector2 axis_values)
    {
        axis = axis_values;
    }

    public override string ToString()
    {
        throw new System.NotImplementedException();
    }
    

}
