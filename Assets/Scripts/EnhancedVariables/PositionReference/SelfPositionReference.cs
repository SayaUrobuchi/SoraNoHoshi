using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfPositionReference : IPositionReference<ShotMiko>, IPositionReference<ShotRule>
{
    public Vector3 Eva(ShotMiko mikosama)
    {
        return mikosama.Battler.CurrentPos;
    }

    public Vector3 Eva(ShotRule ruler)
    {
        return ruler.Battler.CurrentPos;
    }

    public string Desc()
    {
        return "自機座標";
    }
}
