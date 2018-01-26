using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitingShotLifeplan : ShotLifeplan
{
    public IValue<ShotMiko> WaitTime = new ConstValue<ShotMiko>(1f);

    private float timer = 0f;

    public override bool IsFinished(ShotMiko mikosama)
    {
        return timer > WaitTime.Eva(mikosama);
    }

    public override void Execute(ShotMiko mikosama)
    {
        timer += StageMaid.DeltaTime;
    }
}
