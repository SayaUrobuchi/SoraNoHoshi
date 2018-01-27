using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetValueShotLifeplan : ShotLifeplan
{
    public string ID = "val0";
    [SelfDesc]
    public IValue<ShotMiko> Value = new ConstValue<ShotMiko>(0f);

    public override bool IsFinished(ShotMiko mikosama)
    {
        return true;
    }

    public override void Execute(ShotMiko mikosama)
    {
        mikosama.SetValue(ID, Value.Eva(mikosama));
    }
}
