using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class LinearMoveShotLifeplan : ShotLifeplan
{
    [SuffixLabel("Deg")]
    [SelfDesc]
    public IValue<ShotMiko> Angle = new ConstValue<ShotMiko>(0f);
    [SelfDesc]
    public IValue<ShotMiko> Speed = new ConstValue<ShotMiko>(1f);
    [SelfDesc]
    public IValue<ShotMiko> Lifetime = new ConstValue<ShotMiko>(-1f);

    private float timer = 0f;

    public override bool IsFinished(ShotMiko mikosama)
    {
        return Lifetime.Eva(mikosama) > 0f && timer > Lifetime.Eva(mikosama);
    }

    public override void Execute(ShotMiko mikosama)
    {
        if (mikosama.Shot != null)
        {
            float t = StageMaid.DeltaTime;
            timer += t;
            float d = Speed.Eva(mikosama) * t;
            mikosama.Shot.transform.Translate(d * new Vector3(Mathf.Cos(Angle.Eva(mikosama) * Mathf.Deg2Rad), Mathf.Sin(Angle.Eva(mikosama) * Mathf.Deg2Rad)));
        }
    }
}
