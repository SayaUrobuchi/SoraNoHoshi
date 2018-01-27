using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetValueShotAction : ShotAction
{
    public string ValueID = "val0";
    [SelfDesc]
    public IValue<ShotRule> Value = new RandomValue<ShotRule>();

    public override void Execute(ShotRule master)
    {
        master.SetValue(ValueID, Value.Eva(master));
    }
}
