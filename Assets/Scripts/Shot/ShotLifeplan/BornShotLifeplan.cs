using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class BornShotLifeplan : ShotLifeplan
{
    [AssetsOnly]
    public Shot SpawnTarget;
    public PositionReference Position;

    public override bool IsFinished(ShotMiko mikosama)
    {
        return true;
    }

    public override void Execute(ShotMiko mikosama)
    {
        Shot shot = GameObject.Instantiate(SpawnTarget);
        shot.transform.position = Position.GetPos(mikosama);
        mikosama.ShotBorn(shot);
    }
}
