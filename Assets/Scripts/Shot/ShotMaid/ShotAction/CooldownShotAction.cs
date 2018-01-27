using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CooldownShotAction : ShotAction
{
    public IValue<ShotRule> Time = new ConstValue<ShotRule>(1f);

    public override void Execute(ShotRule master)
    {
        master.Timer = Time.Eva(master);
    }
}
