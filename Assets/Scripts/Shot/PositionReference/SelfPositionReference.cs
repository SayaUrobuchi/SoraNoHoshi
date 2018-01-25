using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfPositionReference : PositionReference
{
    public override Vector3 GetPos(ShotMiko mikosama)
    {
        return mikosama.Battler.CurrentPos;
    }
}
