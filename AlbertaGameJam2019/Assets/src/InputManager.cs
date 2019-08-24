using System.Collections;
using System.Collections.Generic;
using Missive_CSharp;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("A"))
            MissiveAggregator.instance.Publish(new SkillDashEvent()); 
        
        if (Input.GetButtonDown("B"))
            MissiveAggregator.instance.Publish(new SkillOneEvent());

        if (Input.GetButtonDown("X"))
            MissiveAggregator.instance.Publish(new SkillTwoEvent());

        if (Input.GetButtonDown("Y"))
            MissiveAggregator.instance.Publish(new SkillThreeEvent());

        if (Input.GetAxis("RightTrigger") > 0)
            MissiveAggregator.instance.Publish(new SwordInputEvent());

        if (Input.GetAxis("LeftTrigger") > 0)
            MissiveAggregator.instance.Publish(new GunInputEvent());
    }
}
