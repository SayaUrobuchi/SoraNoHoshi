using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfFirePositionReference : IPositionReference<ShotMiko>, IPositionReference<ShotRule>
{
    public string FirePosID = "Fire";

    public Vector3 Eva(ShotMiko mikosama)
    {
        return mikosama.Battler.GetFirePosition(FirePosID);
    }

    public Vector3 Eva(ShotRule ruler)
    {
        return ruler.Battler.GetFirePosition(FirePosID);
    }

    public string Desc()
    {
        return "自機定位["+FirePosID+"]";
    }
}
